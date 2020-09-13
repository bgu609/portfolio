#include <opencv2/opencv.hpp>
#include <iostream>

using namespace cv;
using namespace std;

int camera(int, char**)
{
	Mat frame;
	VideoCapture cap;

	cap.open(0);

	int deviceID = 0;
	int apiID = cv::CAP_ANY;

	cap.open(deviceID+ apiID);

	if (!cap.isOpened())
	{
		cerr << "ERROR! Unable to open Camera\n";
		return -1;
	}

	cout << "Start grabbing" << endl
		<< "Press any key to terminate" << endl;

	for (;;)
	{
		cap.read(frame);

		if (frame.empty())
		{
			cerr << "ERROR! blank frame grabbed\n";
			break;
		}

		imshow("Live", frame);
		
		if (waitKey(5) >= 0)
		{
			break;
		}
	}

	return 0;
}