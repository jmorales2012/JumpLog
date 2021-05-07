using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JumpLog.Models;

namespace JumpLog.Services
{
    public class JumpData : IJumpData
    {
        public List<Jump> JumpList { get; set; }

        public JumpData()
        {
            JumpList = new List<Jump>();

            JumpList.Add(new Jump()
            {
                Date = new DateTime(2018, 3, 21),
                Location = "Rogers",
                Aircraft = "C-130"
            });

            JumpList.Add(new Jump()
            {
                Date = new DateTime(2021, 5, 2),
                Location = "Rogers",
                Aircraft = "C-17"
            });

            JumpList.Add(new Jump()
            {
                Date = new DateTime(2021, 6, 15),
                Location = "Rogers",
                Aircraft = "C-130"
            });
        }
    }
}
