namespace PowerPainter
{
    // Interfaces are a description of what objects that share the same interface should be able to do.
    //
    // Objects that can be drawn by the Main form should
    // meet a specific set of behaviors. It these behaviors are not offered
    // the draw object cannot be processed by the form
    //
    // What can a DrawObject do? Paint, Delete and Resize
    public interface IDrawObject
    {
        // Paint itself to the canvas
        void paint();

        // Delete itself from the canvas
        void delete();
    }
}