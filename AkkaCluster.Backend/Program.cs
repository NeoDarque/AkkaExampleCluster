using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Akka.Actor;
using AkkaCluster.Backend.Actors;

namespace AkkaCluster.Backend {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Starting backend...");

            using(var system = ActorSystem.Create("ClusterSystem")) {
                system.ActorOf<BackendActor>("backend");
                system.AwaitTermination();
            }
        }
    }
}
