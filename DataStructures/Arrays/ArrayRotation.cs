/*
Given an array of integers arr[] of size N and an integer, the task is to rotate the array elements to the left by d positions.
Input: 
arr[] = {1, 2, 3, 4, 5, 6, 7}, d = 2
Output: 3 4 5 6 7 1 2
*/

/*
Phương pháp 1: Sử dụng mảng tạm thời
Sau khi xoay d vị trí sang trái, d phần tử đầu tiên trở thành d phần tử cuối cùng của mảng :
-Đầu tiên lưu trữ các phần tử từ chỉ số d đến N-1 vào mảng tạm thời.
-Sau đó lưu trữ d phần tử đầu tiên của mảng ban đầu vào mảng tạm thời.
-Sao chép lại các phần tử của mảng tạm thời vào mảng ban đầu
*/
