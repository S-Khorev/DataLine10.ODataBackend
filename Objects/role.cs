﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLine.DataLine10
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    //  *** Start programmer edit section *** (Using statements)

    //  *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Role.
    /// </summary>
    //  *** Start programmer edit section *** (role CustomAttributes)

    //  *** End programmer edit section *** (role CustomAttributes)
    [PublishName("DataLine.ProtoOne.Role")]
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("roleE", new string[] {
            "name as \'Name\'",
            "description as \'Description\'"})]
    [View("roleL", new string[] {
            "name as \'Name\'",
            "description as \'Description\'"})]
    public class role : ICSSoft.STORMNET.DataObject
    {
        
        private string fname;
        
        private string fdescription;
        
        //  *** Start programmer edit section *** (role CustomMembers)

        //  *** End programmer edit section *** (role CustomMembers)

        
        /// <summary>
        /// name.
        /// </summary>
        //  *** Start programmer edit section *** (role.name CustomAttributes)

        //  *** End programmer edit section *** (role.name CustomAttributes)
        [StrLen(32)]
        [PublishName("Name")]
        [NotNull()]
        public virtual string name
        {
            get
            {
                //  *** Start programmer edit section *** (role.name Get start)

                //  *** End programmer edit section *** (role.name Get start)
                string result = this.fname;
                //  *** Start programmer edit section *** (role.name Get end)

                //  *** End programmer edit section *** (role.name Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (role.name Set start)

                //  *** End programmer edit section *** (role.name Set start)
                this.fname = value;
                //  *** Start programmer edit section *** (role.name Set end)

                //  *** End programmer edit section *** (role.name Set end)
            }
        }
        
        /// <summary>
        /// description.
        /// </summary>
        //  *** Start programmer edit section *** (role.description CustomAttributes)

        //  *** End programmer edit section *** (role.description CustomAttributes)
        [StrLen(255)]
        [PublishName("Description")]
        public virtual string description
        {
            get
            {
                //  *** Start programmer edit section *** (role.description Get start)

                //  *** End programmer edit section *** (role.description Get start)
                string result = this.fdescription;
                //  *** Start programmer edit section *** (role.description Get end)

                //  *** End programmer edit section *** (role.description Get end)
                return result;
            }
            set
            {
                //  *** Start programmer edit section *** (role.description Set start)

                //  *** End programmer edit section *** (role.description Set start)
                this.fdescription = value;
                //  *** Start programmer edit section *** (role.description Set end)

                //  *** End programmer edit section *** (role.description Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "roleE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View roleE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("roleE", typeof(DataLine.DataLine10.role));
                }
            }
            
            /// <summary>
            /// "roleL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View roleL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("roleL", typeof(DataLine.DataLine10.role));
                }
            }
        }
    }
}
