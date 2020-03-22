namespace lab3
{
    public static class SpaceSettings
    {
        private static float ZeroScreenPositionX = 140f;
        private static float ZeroScreenPositionY = 140f;
        
        public static Vector2 ScreenZero => new Vector2(ZeroScreenPositionX, ZeroScreenPositionY);

        public static Vector2 WorldPointToScreen(Vector3 point)
        {
            return new Vector2(ZeroScreenPositionX + point.Y, ZeroScreenPositionY - point.Z);
        }
    }
}