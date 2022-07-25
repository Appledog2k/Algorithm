/* Danh sách liên kết đơn
Head => node(data|con trỏ next : chứa địa node tiếp theo) + node(data|con trỏ next) => null
*/
//* kích thước của danh sách liên kết đơn là kích thước động
namespace singleLinkerList
{
    public class Node
    {
        //* chứa dữ liệu của node hiện tại
        public int data;
        //* chứa địa chỉ của node tiếp theo
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }
    }

}