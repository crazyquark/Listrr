﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Listrr.API.Trakt.Models.Filters;
using Microsoft.AspNetCore.Identity;
using TraktNet.Enums;

namespace Listrr.Data.Trakt
{

    public enum ListType
    {
        Movie,
        Show
    }

    public class TraktList
    {

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public uint Id { get; set; }

        public string Name { get; set; }

        public ListType Type { get; set; }

        public string Slug { get; set; }

        public bool Process { get; set; }

        public DateTime LastProcessed { get; set; }

        public IdentityUser Owner { get; set; }


        #region Basic Filter

        public string Query { get; set; }

        public TraktSearchField Filter_SearchField { get; set; }

        public TranslationsBasicFilter Filter_Translations { get; set; }

        #endregion

        #region Common Filter

        public YearsCommonFilter Filter_Years { get; set; }

        public RuntimesCommonFilter Filter_Runtimes { get; set; }

        public RatingsCommonFilter Filter_Ratings { get; set; }

        public LanguagesCommonFilter Filter_Languages { get; set; }

        public GenresCommonFilter Filter_Genres { get; set; }

        public CountriesCommonFilter Filter_Countries { get; set; }

        #endregion

        #region Movie Filter

        public CertificationsMovieFilter Filter_Certifications { get; set; }

        #endregion

    }
}