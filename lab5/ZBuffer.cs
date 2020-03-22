using System.Collections.Generic;
using System.Drawing;

namespace lab5
{
    public class ZBuffer
    {
        public readonly float[,] Buffer;

        public ZBuffer()
        {
            Buffer = new float[360, 360];
            ClearBuffer();
        }

        public void Render(Bitmap bitmap, List<Polygon> polygons)
        {
            ClearBuffer();
            
            for (int line = 0; line < bitmap.Height; line++)
            {
                // Z буфер хранит Z-кординату каждой точки изображения
                // Bitmap хранит цвет каждой точки изображения

                for (int column = 0; column < bitmap.Width; column++)
                {
                    var currentPoint = new Vector2(line, column);

                    foreach (var polygon in polygons)
                    {
                        // Проходимся по всем полигонам и определяем
                        // 1. Принадлежит ли точка полигону
                        //    Если не принадлежит идем к следующему полигону
                        // 2. Z-координату точки на полигоне
                        //    Если текущее значение Z-буфера больше, то идем к следующему полигону 
                        // 3. Цвет полигона
                        //    Записываем цвет полигона в битовую карту

                        var isContainsPoint = polygon.IsContainsPoint(currentPoint);

                        if (isContainsPoint)
                        {
                            var zValue = polygon.GetZValueOfPoint(currentPoint);

                            if (zValue > Buffer[line, column])
                            {
                                Buffer[line, column] = zValue;
                                bitmap.SetPixel(line, column, polygon.Color);
                            }
                        }
                    }
                }
            }
        }

        private void ClearBuffer()
        {
            for (var i = 0; i < Buffer.GetLength(0); i++)
            for (var j = 0; j < Buffer.GetLength(1); j++)
                Buffer[i, j] = float.NegativeInfinity;
        }
    }
}
