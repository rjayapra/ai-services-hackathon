﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using Azure.AI.Language.Conversations;


namespace OrchestrationWorkflow.OW
{
    /// <summary>
    /// Options for interacting with the CLU service. 
    /// </summary>
    public class OWOptions
    {
        /// <summary>
        /// Creates an instance of  <see cref="OWOptions"/> containing the CLU Application as well as optional configurations.
        /// </summary>
        public OWOptions(OWApplication app)
        {
            OWApplication = app;
        }

        /// <summary>
        /// An instance of the <see cref="CluApplication"/> class containing connection details for your CLU application.
        /// </summary>
        public OWApplication OWApplication { get; }

        /// <summary>
        /// If true, the query will be kept by the service for customers to further review, to improve the model quality.
        /// </summary>
        public bool? IsLoggingEnabled { get; set; }

        /// <summary>
        /// The language to be used with this recognizer.
        /// </summary>
        public string Language { get; set; }

        /// <summary>
        /// If set to true, the service will return a more verbose response.
        /// </summary>
        public bool? Verbose { get; set; }

        /// <summary>
        /// The name of the target project this request is sending to directly.
        /// </summary>
        public string DirectTarget { get; set; }
    }
}
