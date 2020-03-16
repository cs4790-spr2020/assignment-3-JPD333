using System;
using System.Collections.Generic;
using System.Text;
using BlabberApp.Domain.Interfaces;

namespace BlabberApp.Domain.Entities
{
    public class BaseEntity : IBaseEntity
    {
        public DateTime CreatedDTTM { get; set; }
        public DateTime ModifiedDTTM { get; set; }
        private string _SysId;

        public BaseEntity()
        {
            _SysId = Guid.NewGuid().ToString();
            CreatedDTTM = DateTime.Now;
            ModifiedDTTM = DateTime.Now;
        }

        public string getSysId()
        {
            return this._SysId;
        }

        public bool Equals(string AnotherID)
        {
            return this._SysId.Equals(AnotherID);
        }
    }
}
