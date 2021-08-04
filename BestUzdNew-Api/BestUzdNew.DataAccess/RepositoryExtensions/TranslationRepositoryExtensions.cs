using BestUzdNew.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BestUzdNew.DataAccess.RepositoryExtensions
{
    public static class TranslationRepositoryExtensions
    {
        public static string AddOrUpdateTranslation(this IRepository<Translation> source, Translation translation)
        {
            source.AddOrUpdate(translation);

            return translation.Alias;
        }
    }
}
