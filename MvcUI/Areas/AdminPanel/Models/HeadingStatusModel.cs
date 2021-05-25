using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace MvcUI.Areas.AdminPanel.Models
{
    public class HeadingStatusModel
    {
        public List<Heading> Headings { get; set; }
        public String StatusColor { get; set; }
    }
}