using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Models;
using DAL;

namespace BLL
{
    
    class DocumentSubmitteddBLL
    {
        
        StudentDAL _dal = new StudentDAL();

        public string AddDocument(DocumetSubmittedModel ds)
        {
            if (ds.documentId==null)
                return "Please enter document id";
            if (ds.academicId ==null)
                return "please enter academic id";
            if(string.IsNullOrWhiteSpace(ds.tc))
                return "please upload tc";
            if (ds.adharcard=="")
                return "please upload adharcard";
            if (ds.oldMarksheet == "")
                return "please upload oldMarksheet";
            
            else
                return "Documents registered succesfully";
                
        }


    }
}
