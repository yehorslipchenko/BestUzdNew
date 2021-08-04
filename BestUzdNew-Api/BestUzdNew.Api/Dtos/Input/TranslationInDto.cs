using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BestUzdNew.Api.Dtos.Input
{
    public class TranslationInDto
    {
        public int LanguageId { get; set; }
        public string Alias { get; set; }
        public string Translation { get; set; }
        public int? TranslationId { get; set; }
        public bool HasExistingTranslation 
        { 
            get 
            { 
                return TranslationId != null; 
            } 
        }
    }
}
