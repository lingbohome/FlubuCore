
//-----------------------------------------------------------------------
// <auto-generated />
//-----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Text;
using FlubuCore.Context;
using FlubuCore.Tasks;
using FlubuCore.Tasks.Attributes;
using FlubuCore.Tasks.Process;

namespace FlubuCore.Tasks.Docker.Node
{
     public partial class DockerNodeUpdateTask : ExternalProcessTaskBase<int, DockerNodeUpdateTask>
     {
        private string _node;

        
        public DockerNodeUpdateTask(string node)
        {
            ExecutablePath = "docker";
            WithArguments("node update");
_node = node;

        }

        protected override string Description { get; set; }
        
        /// <summary>
        /// Availability of the node ("active"|"pause"|"drain")
        /// </summary>
        [ArgKey("--availability")]
        public DockerNodeUpdateTask Availability(string availability)
        {
            WithArgumentsKeyFromAttribute(availability.ToString());
            return this;
        }

        /// <summary>
        /// Add or update a node label (key=value)
        /// </summary>
        [ArgKey("--label-add")]
        public DockerNodeUpdateTask LabelAdd(string labelAdd)
        {
            WithArgumentsKeyFromAttribute(labelAdd.ToString());
            return this;
        }

        /// <summary>
        /// Remove a node label if exists
        /// </summary>
        [ArgKey("--label-rm")]
        public DockerNodeUpdateTask LabelRm(string labelRm)
        {
            WithArgumentsKeyFromAttribute(labelRm.ToString());
            return this;
        }

        /// <summary>
        /// Role of the node ("worker"|"manager")
        /// </summary>
        [ArgKey("--role")]
        public DockerNodeUpdateTask Role(string role)
        {
            WithArgumentsKeyFromAttribute(role.ToString());
            return this;
        }
        protected override int DoExecute(ITaskContextInternal context)
        {
             WithArguments(_node);

            return base.DoExecute(context);
        }

     }
}
