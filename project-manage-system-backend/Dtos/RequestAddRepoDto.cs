﻿namespace project_manage_system_backend.Dtos
{

    public class RequestAddRepoDto
    {
        public int projectId { get; set; }

        public string url { get; set; }

        public bool isSonarqube { get; set; }

        /// <summary>
        /// foramt: "帳號:密碼"
        /// encryption:base64
        /// </summary>
        public string accountColonPw { get; set; }

        /// <summary>
        /// Sonarqube網址
        /// </summary>
        public string sonarqubeUrl { get; set; }

        /// <summary>
        /// sonarqube projectkey
        /// </summary>
        public string projectKey { get; set; }

        public string accessToken { get; set; }
    }
}
