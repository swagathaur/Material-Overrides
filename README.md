# Material-Overrides
A small repository hosting some basic Material modification within Unity!

To set the scene, this would not have a huge amount of use in day-to-day applications, however if you are doing some Whacky Wavy things where multiple meshes using multiple materials all need to be kept in sync, this could be helpful.

Its a boilerplate setup that allows you to control changes to a Renderer, with specific implementation of using it to apply changers to Shaders on materials by simply adding a `RendererOverrider` component to a base gameobject, then a `RendererOverrideTarget` component to each renderer that you would like to be impacted by the changes.

![image](https://user-images.githubusercontent.com/16999501/189258543-eabd6a27-9fba-40b1-b2b1-42e25653cc48.png)
You can then add multiple "BindableSources" to speficiy what values you would like to change.
