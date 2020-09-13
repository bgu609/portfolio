#include <opencv2/opencv.hpp>
#include <opencv2/highgui.hpp>
#include <opencv2/core.hpp>
#include <iostream>

using namespace cv;
using namespace std;

int main()
{
	Mat image;
	image = imread("test\\test1.png");

	if (image.empty())
	{
		cout << "image reading error" << endl;
		return 0;
	}

	resize(image, image, Size(), 0.5, 0.5);

	Mat gray;
	cvtColor(image, gray, COLOR_BGR2GRAY);
	medianBlur(gray, gray, 9);

	Mat threshold;
	adaptiveThreshold(gray,threshold, 255, ADAPTIVE_THRESH_MEAN_C, THRESH_BINARY_INV, 11, 2);

	imshow("Test image", image);
	imshow("Gray image", gray);
	imshow("threshold", threshold);

	waitKey(0);

	return 0;
}