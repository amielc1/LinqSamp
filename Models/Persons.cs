using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{

    /*CREATE TABLE [dbo].[Persons] (
    [Id]   INT           NOT NULL,
    [Name] NVARCHAR (50) NOT NULL,
    [Age]  FLOAT (53)    NULL,
    CONSTRAINT [PK_Persons] PRIMARY KEY CLUSTERED ([Id] ASC)
);

*/
    public class Persons
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual float Age { get; set; }
    }
}
