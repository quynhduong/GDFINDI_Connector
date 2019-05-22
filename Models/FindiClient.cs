using GDfindi;
using GDfindi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace MasterDetailsDemo.Models
{
    public class FindiClient
    {
        public GDFService _svc;
        public Project _project;

        public FindiClient()
        {
            _svc = new GDFService();
            _project = null;
        }

        public async Task<string> Login(string user, string password)
        {

            var ret = await _svc.LoginAsync(user, password);
            if(!ret)
            {
                return _svc.LastError.LastMessage;
            }
            var projects = await _svc.GetProjectsAsync();
            return null;
        }

        // lo bo chu out string r
        internal bool Load(int id,  out string error)
        {
            error = "";
            
            // 空のプロジェクトはエラーになる（プロセスとステーション、製品と部品と関連付けが必要
            //Get projects method => return result
            _project = _svc.GetProjectAsync(id).Result;
           // Task<ProjectInfo[]> projectinfo =_svc.GetProjectsAsync(pattern);
            
            if (_project == null)
            {
                error = _svc.LastError.LastMessage;
                return false;
            }
            return true;
        }

        public void Initialize(string name, string desc)
        {
            _project = new Project(name)
            {
                Desc = desc,
                Access = Shared.None,
            };
        }


    }
}