using System;
using System.Collections.Generic;
using System.Text;

namespace DataLibrary.Models
{
    public class ReactionTypeModel
    {
        public ReactionTypeModel(int typeID, string typeName, string iconSource)
        {
            TypeID = typeID;
            TypeName = typeName;
            IconSource = iconSource;
        }
        public ReactionTypeModel()
        {

        }

        public int TypeID { get; set; }
        public string TypeName { get; set; }
        public string IconSource { get; set; }
    }
}
