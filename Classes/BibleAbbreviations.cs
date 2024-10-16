﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibleBookAbbreviations {
    public class BibleAbbreviations {
        public static Dictionary<string, string> keyValuePairs = new Dictionary<string, string>
        {
            {"창세기", "창"}, 
            {"출애굽기", "출"}, 
            {"레위기", "레"}, 
            {"민수기", "민"}, 
            {"신명기", "신"}, 
            {"여호수아", "수"}, 
            {"사사기", "삿"}, 
            {"룻기", "룻"}, 
            {"사무엘상", "삼상"},
            {"사무엘하", "삼하"}, 
            {"열왕기상", "왕상"}, 
            {"열왕기하", "왕하"}, 
            {"역대상", "대상"}, 
            {"역대하", "대하"}, 
            {"에스라", "스"}, 
            {"느헤미야", "느"}, 
            {"에스더", "에"},
            {"욥기", "욥"}, 
            {"시편", "시"}, 
            {"잠언", "잠"}, 
            {"전도서", "전"}, 
            {"아가", "아"}, 
            {"이사야", "사"}, 
            {"예레미야", "렘"}, 
            {"예레미야애가", "애"}, 
            {"에스겔", "겔"},
            {"다니엘", "단"}, 
            {"호세아", "호"}, 
            {"요엘", "엘"}, 
            {"아모스", "암"},
            {"오바댜", "옵"},
            {"요나", "욘"},
            {"미가", "미"}, 
            {"나훔", "나"}, 
            {"하박국", "합"},
            {"스바냐", "습"}, 
            {"학개", "학"}, 
            {"스가랴", "슥"}, 
            {"말라기", "말"},
            {"마태복음", "마"}, 
            {"마가복음", "막"}, 
            {"누가복음", "눅"}, 
            {"요한복음", "요"}, 
            {"사도행전", "행"},
            {"로마서", "롬"}, 
            {"고린도전서", "고전"},
            {"고린도후서", "고후"}, 
            {"갈라디아서", "갈"}, 
            {"에베소서", "엡"}, 
            {"빌립보서", "빌"}, 
            {"골로새서", "골"},
            {"데살로니가전서", "살전"}, 
            {"데살로니가후서", "살후"}, 
            {"디모데전서", "딤전"}, 
            {"디모데후서", "딤후"}, 
            {"디도서", "딛"}, 
            {"빌레몬서", "몬"}, 
            {"히브리서", "히"},
            {"야고보서", "약"},
            {"베드로전서", "벧전"},
            {"베드로후서", "벧후"},
            {"요한일서", "요일"},
            {"요한이서", "요이"},
            {"요한삼서", "요삼"}, 
            {"유다서", "유"}, 
            {"요한계시록", "계"}
        };

        public static Dictionary<string, string> findFile = new Dictionary<string, string>
        {
            {"창세기", "01. 창세기"},
            {"출애굽기", "02. 출애굽기"}, 
            {"레위기", "03. 레위기"}, 
            {"민수기", "04. 민수기"}, 
            {"신명기", "05. 신명기"}, 
            {"여호수아", "06. 여호수아"},
            {"사사기", "07. 사사기"},
            {"룻기", "08. 룻기"}, 
            {"사무엘상", "09. 사무엘상"},
            {"사무엘하", "10. 사무엘하"}, 
            {"열왕기상", "11. 열왕기상"},
            {"열왕기하", "12. 열왕기하"}, 
            {"역대상", "13. 역대상"},
            {"역대하", "14. 역대하"}, 
            {"에스라", "15. 에스라"}, 
            {"느헤미야", "16. 느헤미야"}, 
            {"에스더", "17. 에스더"},
            {"욥기", "18. 욥기"}, 
            {"시편", "19. 시편"}, 
            {"잠언", "20. 잠언"}, 
            {"전도서", "21. 전도서"}, 
            {"아가", "22. 아가"},
            {"이사야", "23. 이사야"}, 
            {"예레미야", "24. 예레미야"}, 
            {"예레미야애가", "25. 예레미야애가"}, 
            {"에스겔", "26. 에스겔"},
            {"다니엘", "27. 다니엘"},
            {"호세아", "28. 호세아"},
            {"요엘", "29. 요엘"}, 
            {"아모스", "30. 아모스"}, 
            {"오바댜", "31. 오바댜"}, 
            {"요나", "32. 요나"},
            {"미가", "33. 미가"},
            {"나훔", "34. 나훔"}, 
            {"하박국", "35. 하박국"},
            {"스바냐", "36. 스바냐"},
            {"학개", "37. 학개"},
            {"스가랴", "38. 스가랴"}, 
            {"말라기", "39. 말라기"},
            {"마태복음", "40. 마태복음"}, 
            {"마가복음", "41. 마가복음"}, 
            {"누가복음", "42. 누가복음"}, 
            {"요한복음", "43. 요한복음"},
            {"사도행전", "44. 사도행전"},
            {"로마서", "45. 로마서"}, 
            {"고린도전서", "46. 고린도전서"}, 
            {"고린도후서", "47. 고린도후서"},
            {"갈라디아서", "48. 갈라디아서"}, 
            {"에베소서", "49. 에베소서"},
            {"빌립보서", "50. 빌립보서"}, 
            {"골로새서", "51. 골로새서"},
            {"데살로니가전서", "52. 데살로니가전서"}, 
            {"데살로니가후서", "53. 데살로니가후서"},
            {"디모데전서", "54. 디모데전서"},
            {"디모데후서", "55. 디모데후서"}, 
            {"디도서", "56. 디도서"}, 
            {"빌레몬서", "57. 빌레몬서"}, 
            {"히브리서", "58. 히브리서"}, 
            {"야고보서", "59. 야고보서"},
            {"베드로전서", "60. 베드로전서"}, 
            {"베드로후서", "61. 베드로후서"},
            {"요한일서", "62. 요한일서"}, 
            {"요한이서", "63. 요한이서"},
            {"요한삼서", "64. 요한삼서"},
            {"유다서", "65. 유다서"},
            {"요한계시록", "66. 요한계시록"}
        };
    }
}
