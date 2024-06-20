using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Models;

public class Task
{
    public String Title { get; set; }
    public String Description { get; set; }

    public Task( String Title, String Description )
    {
        this.Title = Title;
        this.Description = Description;
    }
}
