﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchedulingClients.FleetManagerServiceReference;
using System.ServiceModel;

namespace SchedulingClients
{
    public class FleetManagerClient : AbstractClient<IFleetManagerService>
    {
        private bool isDisposed = false;

        /// <summary>
        /// Creates a new FleetManagerClient
        /// </summary>
        /// <param name="netTcpUri">net.tcp address of the job builder service</param>
        public FleetManagerClient(Uri netTcpUri)
            : base(netTcpUri)
        {
        }

        /// <summary>
        /// Requests fleet manager freeze
        /// </summary>
        /// <param name="success">True if frozen</param>
        /// <returns>ServiceOperationResult</returns>
        public ServiceOperationResult TryRequestFreeze(out bool success)
        {
            Logger.Info("TryRequestFreeze()");

            try
            {
                var result = RequestFreeze();
                success = result.Item1;
                return ServiceOperationResult.FromServiceCallData(result.Item2);
            }
            catch (Exception ex)
            {
                success = false;
                return HandleClientException(ex);
            }
        }

        /// <summary>
        /// Requests fleet manager unfreeze
        /// </summary>
        /// <param name="success">True if unfrozen</param>
        /// <returns>ServiceOperationResult</returns>
        public ServiceOperationResult TryRequestUnfreeze(out bool success)
        {
            Logger.Info("TryRequestUnfreeze()");

            try
            {
                var result = RequestUnfreeze();
                success = result.Item1;
                return ServiceOperationResult.FromServiceCallData(result.Item2);
            }
            catch (Exception ex)
            {
                success = false;
                return HandleClientException(ex);
            }
        }

        protected override void Dispose(bool isDisposing)
        {
            Logger.Debug("Dispose({0})", isDisposing);

            if (isDisposed)
            {
                return;
            }

            isDisposed = true;

            base.Dispose(isDisposing);
        }

        private Tuple<bool, ServiceCallData> RequestFreeze()
        {
            Logger.Debug("RequestFreeze()");

            if (isDisposed)
            {
                throw new ObjectDisposedException("FleetManagerClient");
            }

            Tuple<bool, ServiceCallData> result;

            using (ChannelFactory<IFleetManagerService> channelFactory = CreateChannelFactory())
            {
                IFleetManagerService channel = channelFactory.CreateChannel();
                result = channel.RequestFreeze();
                channelFactory.Close();
            }

            return result;
        }

        private Tuple<bool, ServiceCallData> RequestUnfreeze()
        {
            Logger.Debug("RequestUnfreeze()");

            if (isDisposed)
            {
                throw new ObjectDisposedException("FleetManagerClient");
            }

            Tuple<bool, ServiceCallData> result;

            using (ChannelFactory<IFleetManagerService> channelFactory = CreateChannelFactory())
            {
                IFleetManagerService channel = channelFactory.CreateChannel();
                result = channel.RequestUnfreeze();
                channelFactory.Close();
            }

            return result;
        }
    }
}