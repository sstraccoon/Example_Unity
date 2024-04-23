using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

//namespace CSharp
//{
//    // 객체지향 > 은닉성
//    class Knight
//    {

//        public int Hp { get; set; }
//        //위와 같이 선언 하면 아래 3줄를 한 번에 만드는 효과를 낸다.


//        private int _hp;
//        public int GetHp() { return _hp; }
//        public void SetHp(int value) { _hp = value; }

//        //protected int hp;

//        //public int Hp
//        //{
//        //    get { return hp; }
//        //    private set { hp = value; }
//        //}


//        // 아래는 이전에 쓰던 방식.
//        //public int GetHp() { return hp; }
//        //public void SetHp(int hp) { this.hp = hp; }
//    }
//    class Property
//    {
//        static void Main(string[] args)
//        {
//            Knight knight = new Knight();
//            knight.Hp = 100;
//        }
//    }
//}
/// <space>
/// //
/// </space>
//namespace Delegate
//{

//    class Program
//    {
//        static void Main(string[] args)
//        {
//        }
//    }
//}
//namespace CSharp  // 델리게이트
//{
//    class Program
//    {
//        // 업체 사장 - 사장의 비서
//        // 우리의 연락처 / 용건을 주고 거꾸로 -> 연락을 달라
//        // 거꾸로 -> 연락을 달라

//        delegate int OnClicked();
//        // delegate -> 형식은 형식인데, 함수 자체를 인자로 넘겨주는 그런 형식
//        // 반환 : int 입력 : void
//        // Onclicked 이 delegate 형식의 이름이다.

//        //UI
//        static void ButtonPressed(OnClicked clickedFunction/* 함수 자체를 인자로 넘겨주고 */)
//        {
//            // 함수를 호출();
//            clickedFunction();
//        }

//        static int TestDelegate()
//        {
//            Console.WriteLine("Hello World");
//            return 0;
//        }

//        static int TestDelegate2()
//        {
//            Console.WriteLine("Hello World 2");
//            return 0;
//        }

//        static void Main(string[] args)
//        {
//            OnClicked clicked = new OnClicked(TestDelegate);
//            clicked += TestDelegate2;

//            ButtonPressed(clicked/* 함수 */);
//        }
//    }
//}
////////

///
///

/// <space>
/// //
/// </space>


//namespace Delegate  // 델리게이트는 아래 Event와 함께 써야 진가를 발휘한다.
//{
//    class program
//    {
//        // 업체 사장 - 사장의 비서
//        // 우리의 연락처 / 용건을 주고 거꾸로 -> 연락을 달라
//        // 거꾸로 -> 연락을 달라

//        delegate int onclicked();
//        // delegate -> 형식은 형식인데, 함수 자체를 인자로 넘겨주는 그런 형식
//        // 반환 : int 입력 : void
//        // onclicked 이 delegate 형식의 이름이다.

//        //ui
//        static void buttonpressed(onclicked clickedfunction/* 함수 자체를 인자로 넘겨주고 */)
//        {
//            // 함수를 호출();
//            clickedfunction();
//        }

//        static int testdelegate()
//        {
//            Console.WriteLine("hello world");
//            return 0;
//        }

//        static int testdelegate2()
//        {
//            Console.WriteLine("hello world 2");
//            return 0;
//        }

//        static void main(string[] args)
//        {
//            onclicked clicked = new onclicked(testdelegate);
//            clicked += testdelegate2;

//            buttonpressed(clicked/* 함수 */);
//        }
//    }
//}

/// <summary>
/// //
/// </summary>


//// 아래는 Event 관련 내용 namespace가 event, main 두개로 되어 있는데
//// 이는 파일 두개에 나눠져 있어야 하는 내용을 하나로 합쳤기 때문이다.
//// 아래와 같은 방식으로 하는 것을 Observer Pattern 이라고 한다.
//namespace Event
//{
//    class InputManager
//    {

//        public delegate void OnInputKey();
//        public event OnInputKey InputKey;


//        public void Update()
//        {
//            if (Console.KeyAvailable == false)
//                return;
//            ConsoleKeyInfo info = Console.ReadKey();
//            if (info.Key == ConsoleKey.A)
//            {
//                //모두한테 알려준다.
//                // 여기에 코드를 넣는 것은 비효율적인 방식이고
//                // input manager의 종속성을 높이는 것이기에 별로 좋은 것은 아니다.

//                InputKey();
//            }
//        }
//    }
//}

//// 아래 내용은 다른 .c# Main 파일에서 적힐 내용.
//namespace Main
//{
//    class Program
//    {

//        static void OnInputTest()
//        {
//            Console.WriteLine("Input Received!");
//        }

//        static void Main(string[] args)
//        {
//            InputManager inputManager = new InputManager();
//            // 여기 빨간 불은 원래 InputManager는 위의 namespace가 다른 파일로 있어야 하기 때문.
//            inputManager.InputKey += OnInputTest();

//            while(true)
//            {
//                inputManager.Update();
//            }
//        }
//    }
//}


/// <space>
/// //
/// </space>

// Lamda : 일회용 함수를 만드는데 사용하는 문법이다.
//namespace Lamda
//{
//    enum ItemType
//    {
//        Weapon,
//        Armor,
//        Amulet,
//        Ring,
//    }

//    enum Rarity
//    {
//        Nurmal,
//        Uncommon,
//        Rare,
//    }

//    class Item
//    {
//        public ItemType ItemType;
//        public Rarity Rarity;
//    }

//    class Program
//    {
//        static List<Item> _items = new List<Item>();

//        delegate bool ItemSelector(Item item);
//        // 아래 처럼 템플릿을 사용할 수 있다.
//        delegate bool ItemSelector<T, Return>(T item);
//        // 위의 코드를 아래 처럼 만들어서 쓸 수도 있다.
//        delegate Return MyFunc<T, Return>(T item);
//        // C#에서 이미 Func라는 이름으로 17개의 함수가 만들어져 있다 (무 입력, 무반환 부터 1반환 16입력까지 있다.)
//        // 반대로 반환을 안 하는 Action 이라는 것도 있다.
//        // 

//        // 위의 MyFunc를 사용하기 위해서는
//        static Item FindItem2(MyFunc<Item, bool> selector) { return null; }

//        //// 람다 1
//        //// 아래 IsWeapon 같이 만들어서 쓰면 한 번이 아니라 여러번 사용 할 수 있는 함수와 같음.
//        //// 한 번만 사용하는게 구지 필요 없는 함수.

//        //static bool IsWeapon(Item item)
//        //{
//        //    return item.ItemType == ItemType.Weapon;
//        //}

//        static Item FindItem(ItemSelector selector)
//        {
//            foreach (Item item in _items)
//            {
//                if (selector(item))
//                    return item;
//            }
//            return null;
//        }



//        static void Main(string[] args)
//        {
//            _items.Add(new Item() { ItemType = ItemType.Weapon, Rarity = Rarity.Nurmal });
//            _items.Add(new Item() { ItemType = ItemType.Armor, Rarity = Rarity.Uncommon });
//            _items.Add(new Item() { ItemType = ItemType.Ring, Rarity = Rarity.Rare });

//            // Lamda : 일회용 함수를 만드는데 사용하는 문법이다.
//            // Anonymous Function : 무명 함수 / 익명 함수

//            //// 람다 
//            //Item item = FindItem(IsWeapon);


//            //// Anonymous Function : 무명 함수 / 익명 함수
//            // Item item = FindItem(delegate (Item item2) { return item2.ItemType == ItemType.Weapon;});

//            //// Lamda : 일회용 함수를 만드는데 사용하는 문법이다.
//            // Item item = FindItem((Item item2) => { return item2.ItemType == ItemType.Weapon; });
//            //// Lamda의 진정한 의미는 선언을 하지 않고 빠르게 사용 하는 것이 더 중요 하다.
//            //// 예로 위의 코드는 아래의 코드와 완전히 같다.
//            ItemSelector selector = new ItemSelector((Item item2) => { return item2.ItemType == ItemType.Weapon; });
//            Item item = FindItem(selector);



//            // MyFunc 를 쓰는 FindItem2를 쓰기 위해서 아래 처럼 사용 가능.
//            MyFunc<Item, bool> selector2 = new MyFunc<Item, bool>((Item item3) => { return item3.ItemType == ItemType.Weapon; });

//            // 위의 코드는 아래 처럼 바꿀수 있다.
//            // Func는 C#에서 제공 한다.
//            Func<Item, bool> selector3 = (Item item4) => { return item4.ItemType == ItemType.Weapon; };



//        }
//    }
//}


/// <space>
/// //
/// </space>

//namespace Reflection
//{
//    class Important : System.Attribute
//    {
//        string message;

//        public Important(string message) { this.message = message; }
//    }
//    class Monster
//    {

//        // hp 입니다. 중요 정보입니다.
//        [Important("Very Important")]
//        public int hp;
//        protected int attack;
//        private float speed;

//        void Attack() { }
//    }

//    class Program
//    {

//        static void Main(string[] args)
//        {
//            Monster monster = new Monster();
//            Type type = monster.GetType();

//            var fields = type.GetFields(System.Reflection.BindingFlags.Public
//                | System.Reflection.BindingFlags.NonPublic
//                | System.Reflection.BindingFlags.Static
//                | System.Reflection.BindingFlags.Instance);

//            foreach (FieldInfo field in fields)
//            {
//                string access = "protected";
//                if (field.IsPublic)
//                    access = "public";
//                else if (field.IsPrivate)
//                    access = "private";

//                var attributes = field.GetCustomAttributes();

//                Console.WriteLine($"{access} {field.FieldType.Name} {field.Name}");
//            }
//        }
//    }
//}


/// <space>
/// //
/// </space>

namespace Nullable
{
    class Program
    {

        static void Main(string[] args)
        {
            int? number = 5;

            int b = number ?? 0;

            if (number != null)
            {
                int a = number.Value;
                Console.WriteLine(a);
            }

            if (number.HasValue)
            {
                int a = number.Value;
                Console.WriteLine(a);
            }

            int c = (number != null) ? 5 : 0;
            // 아래 ?? 는 위의 삼항 연산자와 같은 의미다.
            // 만약 null이 아니라면 number값이 들어가고, null이라면 0값이 들어간다.
            int d = number ?? 0;

            Console.WriteLine(d);
        }
    }
}

/// <space>
/// //
/// </space>

//namespace Example
//{
//    class Program
//    {

//        static void Main(string[] args)
//        {
//            Console.WriteLine("delegate");
//        }
//    }
//}

/// <space>
/// //
/// </space>
