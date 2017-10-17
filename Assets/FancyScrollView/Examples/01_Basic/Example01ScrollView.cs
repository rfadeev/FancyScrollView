﻿using UnityEngine;
using System.Collections.Generic;

namespace FancyScrollView
{
    public class Example01ScrollView : FancyScrollView<Example01CellDto>
    {
        [SerializeField]
        ScrollPositionController scrollPositionController;

        protected void Awake()
        {
            scrollPositionController.OnUpdatePosition(UpdatePosition);
        }

        public void UpdateData(List<Example01CellDto> data)
        {
            cellData = data;
            scrollPositionController.SetDataCount(cellData.Count);
            UpdateContents();
        }
    }
}
