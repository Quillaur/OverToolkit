#pragma once

using namespace Windows::UI;
using namespace Windows::UI::Xaml::Media;

namespace Over2D::Brushes
{
	public ref class RadialGradientBrush sealed : public GradientBrush
	{
	public:
		RadialGradientBrush();
		RadialGradientBrush(
			Color startColor,
			Color endColor
		);
		RadialGradientBrush(
			GradientStopCollection^ gradientStopCollection
		);
	};
}
