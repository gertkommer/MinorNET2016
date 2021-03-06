// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace FrontEnd.Agents
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

    /// <summary>
    /// Extension methods for CursusService.
    /// </summary>
    public static partial class CursusServiceExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<CursusInstantie> ApiV1CursusGet(this ICursusService operations)
            {
                return Task.Factory.StartNew(s => ((ICursusService)s).ApiV1CursusGetAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<CursusInstantie>> ApiV1CursusGetAsync(this ICursusService operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiV1CursusGetWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cursus'>
            /// </param>
            public static void ApiV1CursusPost(this ICursusService operations, IList<CursusInstantie> cursus = default(IList<CursusInstantie>))
            {
                Task.Factory.StartNew(s => ((ICursusService)s).ApiV1CursusPostAsync(cursus), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cursus'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task ApiV1CursusPostAsync(this ICursusService operations, IList<CursusInstantie> cursus = default(IList<CursusInstantie>), CancellationToken cancellationToken = default(CancellationToken))
            {
                await operations.ApiV1CursusPostWithHttpMessagesAsync(cursus, null, cancellationToken).ConfigureAwait(false);
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            public static CursusInstantie ApiV1CursusByIdGet(this ICursusService operations, int id)
            {
                return Task.Factory.StartNew(s => ((ICursusService)s).ApiV1CursusByIdGetAsync(id), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CursusInstantie> ApiV1CursusByIdGetAsync(this ICursusService operations, int id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ApiV1CursusByIdGetWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
