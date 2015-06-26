using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;
using Akka.Cluster.Routing;
using Akka.Routing;
using AkkaCluster.Shared.Messages;

namespace AkkaCluster.Frontend {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Starting frontend...");

            using(var system = ActorSystem.Create("ClusterSystem")) {
                var router = system.ActorOf(Props.Empty.WithRouter(FromConfig.Instance), "backend");

                while(true) {
                    var text = Console.ReadLine();
                    router.Tell(new TextMessage { Text = text });
                }
            }
        }
    }
}
