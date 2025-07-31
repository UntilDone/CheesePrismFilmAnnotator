using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheeseFilmAnalystics.Model
{
    public class MovieData
    {
        public string Title { get; set; }
        public string ImagePath { get; set; } // 영화 스틸컷 경로
        public ObservableCollection<ColorData> ExtractedColors { get; set; } // 추출된 색상 팔레트
        public ObservableCollection<EmotionTag> EmotionTags { get; set; } // 감정 태그
                                                                          // 기타 LUT 관련 데이터 (예: 색온도, 대비 등)
    }

    public class ColorData
    {
        public Color Color { get; set; } // WPF Color 객체
        public string HexValue { get; set; }
        // 색상의 비율, 설명 등 추가 정보
    }

    public class EmotionTag
    {
        public string Name { get; set; } // 예: "몽환적", "우울함", "활기찬"
        public string Description { get; set; }
        public ObservableCollection<string> AssociatedColors { get; set; } // 이 감정과 연관된 색상 (선택 사항)
    }
}
