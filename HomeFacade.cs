//-----------------------------------------------------------------------
// <copyright file="HomeFacade.cs" company="CompanyName">
//     Company copyright tag.
// </copyright>
//-----------------------------------------------------------------------
namespace DesignPatterns
{
    using System;

    /// <summary>
    /// facade class
    /// </summary>
   public class HomeFacade
    {
        /// <summary>
        /// variable of type light
        /// </summary>
        private Lights lights;

        /// <summary>
        /// variable of type musicSystem
        /// </summary>
        private MusicSystem musicSystem;

        /// <summary>
        /// variable of type TV
        /// </summary>
        private TV tv;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomeFacade"/> class.
        /// </summary>
        public HomeFacade()
        {
            this.Lights = new Lights();
            this.MusicSystem = new MusicSystem();
            this.Tv = new TV();
        }

        /// <summary>
        /// Gets or sets the lights.
        /// </summary>
        /// <value>
        /// The lights.
        /// </value>
        public Lights Lights { get => this.lights; set => this.lights = value; }

        /// <summary>
        /// Gets or sets the music system.
        /// </summary>
        /// <value>
        /// The music system.
        /// </value>
        public MusicSystem MusicSystem { get => this.musicSystem; set => this.musicSystem = value; }

        /// <summary>
        /// Gets or sets the TV.
        /// </summary>
        /// <value>
        /// The TV.
        /// </value>
        public TV Tv { get => this.tv; set => this.tv = value; }

        /// <summary>
        /// Leaves the home.
        /// </summary>
        public void LeaveHome()
        {
            Console.WriteLine("******LEAVING HOME*********");
            this.Lights.SwitchOffLights();
            this.Tv.SwitchOffTV();
            this.MusicSystem.SwitchOffMusicSystem();
        }

        /// <summary>
        /// Arrives the home.
        /// </summary>
        public void ArriveHome()
        {
            Console.WriteLine("*********ARRIVED HOME********");
            this.Lights.SwitchOnLights();
            this.Tv.SwitchOnTV();
            this.MusicSystem.SwitchOnMusicSystem();
        }
    }

    /// <summary>
    /// sub system one
    /// </summary>
    public class Lights
    {
        /// <summary>
        /// Switches the on lights.
        /// </summary>
        public void SwitchOnLights()
        {
            Console.WriteLine("lights switched ON");
        }

        /// <summary>
        /// Switches the off lights.
        /// </summary>
        public void SwitchOffLights()
        {
            Console.WriteLine("lights switched OFF");
        }
    }

    /// <summary>
    /// sub system two
    /// </summary>
    public class MusicSystem
    {
        /// <summary>
        /// Switches the on music system.
        /// </summary>
        public void SwitchOnMusicSystem()
        {
            Console.WriteLine("muscic system switched ON");
        }

        /// <summary>
        /// Switches the off music system.
        /// </summary>
        public void SwitchOffMusicSystem()
        {
            Console.WriteLine("muscic system switched Off");
        }
    }

    /// <summary>
    /// sub system three
    /// </summary>
    public class TV
    {
        /// <summary>
        /// Switches the on TV.
        /// </summary>
        public void SwitchOnTV()
        {
            Console.WriteLine("TV Switched ON");
        }

        /// <summary>
        /// Switches the off TV.
        /// </summary>
        public void SwitchOffTV()
        {
            Console.WriteLine("TV Switched OFF");
        }
    }
}
