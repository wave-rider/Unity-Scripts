# 9 Jan 2026
The Probuilder UI is dramatically changed in Unity 6. It was a bit of surprise  
[ProBuilder window missing in Unity 6](https://discussions.unity.com/t/probuilder-window-missing-in-unity-6/944138/99)

# 3 Jan 2026
Graphics performance optimization
1. Game -> Play maximized. It increases the FPS on the Oculus Quest 2 by 75%
2. [7 Ways to Optimize your Unity Project with URP](https://www.youtube.com/watch?v=NFBr21V0zvU)
   - Select an object's light component, Mode:Baked
   - Object, Mesh Renderer, Lightmapping
   - 


# 16 Mar 2025
[What are normals](https://www.youtube.com/watch?v=hkTjreiookM)

# 27 Feb 2024
[How to make a Mesh in Unity (Dynamic, Vertices, UVs, Triangles)](https://www.youtube.com/watch?v=11c9rWRotJ8&t=0s)

# 24 Jan 2025
[Setup Unity VR Project](https://learn.unity.com/tutorial/vr-project-setup)

[Setup Unity VR Project from scratch](https://learn.unity.com/tutorial/create-a-vr-starter-project-from-scratch#)

# 27 Apr 2024
[Unity XR 2023 - Make a VR Escape Room by Ryan Murray](https://youtube.com/playlist?list=PLZTzR-SmgYcP8lUf4PAqNyBdpEieYX8mU&feature=shared)

# 26 Apr 2024
[Unity Create with VR Challenge 1.4: Rearrangeable Books](https://www.youtube.com/watch?v=1GxQBq9srTI)
# 25 Apr 2024
[Build a Virtual Reality Escape Room in Unity](https://www.youtube.com/watch?v=s5D9u7jSXNQ )

# 24 Apr 2024
Looking at the XR interactables
https://www.youtube.com/watch?v=ImPZyIM6XNs
The Secret to Virtual Reality: Make VR Games Without the Headset

# 3 March 2024
https://unity.com/how-to/learning-c-sharp-unity-beginners

https://docs.unity3d.com/Manual/ExecutionOrder.html

# 2 March 2024
Installation steps
1. Install Unity hub
2. Install git extenstions
https://github.com/gitextensions/gitextensions/releases
3. Install .NET desktop runtime
4. Install choco
- https://chocolatey.org/install
- Run Powershell as an admin
- Install choco
5. Install Git
  
   choco upgrade -y git
6. Install kdiff3
  
   choco upgrade -y kdiff3

# 6-Feb-2024
From https://learn.unity.com/tutorial/add-light-sources-to-your-scene

Note: GameObjects need to be flagged as Static to be included in the lightmap for ambient lighting. This is because lightmap data is precalculated and can only be calculated for GameObjects that don’t move at runtime. 

Color resources for lighting
Khan Academy’s Pixar in a Box course unit on color science: A foundational primer that will take you deeper into the science of color than this learning experience.

Draw Paint Academy’s Color theory guide for artists: An artist-perspective guided tour through color theory, and a useful refresher for those with a background in visual art.

Massachusetts College of Art and Design’s Color theory research guide: A starting point to help you begin your own research journey into the aspects of color theory that interest you most.

Bill Williams’s Stage Lighting Design on General Design Methods: Although written with a focus on theater lighting design, the basic concepts are still relevant for lighting for 3D digital spaces.

# 3-Feb-2024
https://learn.unity.com/mission/creative-core-lighting

# 24-Jan-2024
https://blog.unity.com/engine-platform/spotlight-team-best-practices-collision-performance-optimization
https://docs.unity3d.com/2023.3/Documentation/Manual/collider-shapes-introduction.html

# 20-Jan-2024
https://www.youtube.com/watch?v=pTz3LMQpvfA
Performance optimization tips: Physics in Unity | Tutorial

https://blog.unity.com/games/optimize-your-mobile-game-performance-get-expert-tips-on-physics-ui-and-audio-settings

convex vs concave
https://www.youtube.com/watch?app=desktop&v=_uE90sarrrc
the convex is like wrapping, it doesnt have holes
the convex shape it has only one entry point and exit point if you draw a line through it


# 17-Jan-2024
Grey Circles Appear Everytime I Select an Object
https://forum.unity.com/threads/grey-circles-appear-everytime-i-select-an-object.467902/
https://docs.unity3d.com/2023.2/Documentation/Manual/GizmosMenu.html
![image](https://github.com/wave-rider/LearningUnity/assets/25537219/5d1dc906-993d-4380-9eb5-2fbb3302149b)


# 16-Jan-2024
https://docs.unity3d.com/2023.2/Documentation/Manual/compound-colliders-introduction.html

# 14.1.2024
Search in Unity-Ctrl-K
https://discussions.unity.com/t/cant-find-unity-quick-search-anywhere/247036

Best advice to learn Unity
https://t.co/LARBpRrOFg

# 7.1.2024
Fixing the normals after the bridge edge loops. 

Mesh->Normals->Flip
The Book is finished based on the tutorial, but the import into Unity is failed.
I can't see the textures.

Looking at the next video while waiting for the answer:
The Basics of Designing 3D Art with Blender and Unity(O'Reilly) - this was very useful. I created a book model eventually.

A new shortcut: Shift-A to add a new object in the object mode.

# 6.1.2024
Building a book continued.
Select edges and hold the Shift button, press F to fill it up
Ctrl-R for a loop cut, in the Loop and cut menu set number of cuts to 5.
TO make the curvy side of the book, select the very middle edge and enable proportional editing by presssing O from the 
keyboard

Important: change Preferences/Navigation/Orbit & Pan/Orbit Mrethod -> Trackball
G = free Translate/Manipulate (X, Y and Z to lock axis) S = free Scale/Resize (X, Y and Z to lock axis) R = free Rotate (X, Y and Z to lock axis) 

## Selecting multiple edges:
 - Tab => Edit mode
 - Shift + Click  to select multiple edges
 - Ctrl-B to bevel the edges
 - select edges - bridge edge loops - to make faces 
 - select faces - Alt-E to bring the menu - extrude along normals
 - select faces - Shift-H to hide evrything except selected faces, bridge edge loops`
 - Select the loop - Mark seam

# 5.1.2024
https://www.youtube.com/watch?v=lZaIkmRK5Gc
How to create a book in Blender | Modeling tutorial in blender
Select a cube, S - X,Y,Z to resize in only 1 direction
Tab - to get into the edit mode
Ctr-R for loop cut

# 3.1.2024
Rigid Bodies • Physics • Unity Game Development for Beginners • Unity Fundamentals • (Pt. 194)
https://www.youtube.com/watch?v=r3fkreqqEMw&list=PLS9G7A6kaaHPC__uNE0GtJTxhGmn5PS0-&index=195
Physic Materials - Unity Official Tutorials
https://www.youtube.com/watch?v=SuUNnwswH94

Mesh Collider • Physics • Unity Game Development for Beginners • Unity Fundamentals • (Pt. 197)
https://www.youtube.com/watch?v=kjTGuCns2lg&list=PLS9G7A6kaaHPC__uNE0GtJTxhGmn5PS0-&index=197
Mesh collider - 2 mesh colliders will not collide unless "Convex" property is checked. Only 255 triangles can be used.

Creating Complex Colliders • Physics • Unity Game Dev Beginners • Unity Fundamentals • (Pt. 198)
https://www.youtube.com/watch?v=lr09elWiRqo&list=PLS9G7A6kaaHPC__uNE0GtJTxhGmn5PS0-&index=198


# 1.1.2024
the Goal - to learn how to create complex colliders in Unity

## Introduction • Physics • Unity Game Development for Beginners • Unity Fundamentals • (Pt. 193)
https://www.youtube.com/watch?v=ZgbnDIxtEpc&list=PLS9G7A6kaaHPC__uNE0GtJTxhGmn5PS0-&index=194

Unity is using NVIDA's Psysx

https://github.com/NVIDIAGameWorks/PhysX/

- Rigidbodies - Non-deforming object that responds to forces, collisions and joints
- Colliders - invisible surface used to calculate collisions
- Physic Materials - Definition of physical properties stored in a modular asset
- Joints(they are called Dynamic constraints in Maya) - constraints behaviour along some axis
- Forces - Energy applied to dynamic objects:
  * Linear
  * Angular (Torque)
- Cloth (special case) Deformable object that reacts to forces & collisions
  * Interactive
  * Skinned

Important: Physics ---> Performance
- Scale ==> 1 Unit = 1 Meter
    


