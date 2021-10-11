using System;
using System.Collections.Generic;
using System.Text;

namespace MathForGames
{
    class Scene
    {
        /// <summary>
        /// Array that contains all actors in the scene
        /// </summary>
        private Actor[] _actors;

        public Scene()
        {
            _actors = new Actor[0];
        }

        public void Start()
        {
            for (int i = 0; i < _actors.Length; i++)
            {
                _actors[i].Start();
            }
                
        }

        public void Update()
        {

        }
        
        public void Draw()
        {

        }

        public void End()
        {

        }
        /// <summary>
        /// Adds an actor 
        /// </summary>
        /// <param name="actor"></param>
        public void AddActor(Actor actor)
        {
            //Creats a temp array that is larger than the orignal array
            Actor[] tempArray = new Actor[_actors.Length + 1];

            //Clopy all the values from the orginal array into the temp array
            for (int i = 0; i < _actors.Length; i++)
            {
                tempArray[i] = _actors[i];
            }

            //Add the new actor to the end of the new array
            tempArray[_actors.Length] = actor;

            //Sets the old array to be the new array
            _actors = tempArray;
        }

        /// <summary>
        /// Removes the actor from the scene
        /// </summary>
        /// <param name="actor">The actor to remove</param>
        /// <returns>False if the actor was not in the scene array</returns>
        public bool RemoveActor(Actor actor)
        {
            //Create a variable to store if the removal was successful
            bool actorRemoved = false;

            //Create a new array that is samller than the orignal
            Actor[] tempArray = new Actor[_actors.Length - 1];

            //Copy all values exept the actor we dont want into the new array
            int j = 0;
            for (int i = 0; i < tempArray.Length; i++)
            {
                //If the actor that the loop is on is not the one to remove...
                if (_actors[i] != actor)
                {
                    //...add the actor into the new array and increment the temp array counter
                    tempArray[j] = _actors[i];
                    j++;
                }
                //Otherwise if this actor is the one to remove...
                else
                {
                    //...set actor removed to true
                    actorRemoved = true;                    
                }
            }

            if (actorRemoved)
            {
                _actors = tempArray;
            }
            
            return actorRemoved;
        }
    }
}
