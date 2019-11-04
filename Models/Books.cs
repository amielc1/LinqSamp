using System;

namespace Models
{
    /*

    CREATE TABLE[dbo].[Books]
    (

   [BookId] INT           NOT NULL,
    [PersonId] INT NOT NULL,
    [BookName] NVARCHAR(50) NOT NULL,

  [Level]     NCHAR(10)    NULL,
    PRIMARY KEY CLUSTERED([BookId] ASC)
);*/
    public class Books
    {
        public virtual int BookId { get; set; }
        public virtual int PersonId { get; set; }
        public virtual string BookName { get; set; }
        public virtual string Level { get; set; }
    }
}
