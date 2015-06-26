using System;
using Akka.Actor;
using AkkaCluster.Shared.Messages;

namespace AkkaCluster.Backend.Actors {
    public class BackendActor : ReceiveActor {
        public BackendActor() {
            Receive<TextMessage>(msg => {
                Console.WriteLine("Backend received text: {0}", msg.Text);
            });
        }
    }
}