#include "d2d1.h"
#include "d2d1_1.h"
#include "DirectXHelper.h"
#include "pch.h"
#include "RadialGradientBrush.h"

using namespace Windows::Foundation;
using namespace Windows::UI;
using namespace Windows::UI::Xaml;

namespace Over2D::Brushes
{
	public ref class RadialGradientBrush sealed : public GradientBrush
	{
	public:
		RadialGradientBrush()
		{
			ID2D1RadialGradientBrush *m_pRadialGradientBrush;
			// Create an array of gradient stops to put in the gradient stop
			// collection that will be used in the gradient brush.
			ID2D1GradientStopCollection *pGradientStops = NULL;

			D2D1_GRADIENT_STOP gradientStops[2];
			gradientStops[0].color = D2D1::ColorF(D2D1::ColorF::Yellow, 1);
			gradientStops[0].position = 0.0f;
			gradientStops[1].color = D2D1::ColorF(D2D1::ColorF::ForestGreen, 1);
			gradientStops[1].position = 1.0f;
			// Create the ID2D1GradientStopCollection from a previously
			// declared array of D2D1_GRADIENT_STOP structs.
			hr = m_pRenderTarget->CreateGradientStopCollection(
				gradientStops,
				2,
				D2D1_GAMMA_2_2,
				D2D1_EXTEND_MODE_CLAMP,
				&pGradientStops
			);

			// The center of the gradient is in the center of the box.
			// The gradient origin offset was set to zero(0, 0) or center in this case.
			if (SUCCEEDED(hr))
			{
				hr = m_pRenderTarget->CreateRadialGradientBrush(
					D2D1::RadialGradientBrushProperties(
						D2D1::Point2F(75, 75),
						D2D1::Point2F(0, 0),
						75,
						75),
					pGradientStops,
					&m_pRadialGradientBrush
				);
			}

			m_pRenderTarget->FillEllipse(ellipse, m_pRadialGradientBrush);
			m_pRenderTarget->DrawEllipse(ellipse, m_pBlackBrush, 1, NULL);
		}

		RadialGradientBrush(Color startColor, Color endColor) { }
		RadialGradientBrush(GradientStopCollection^ gradientStopCollection) { }

		property Point Center {
			Point get();
			void set(Point value);
		}

		property Point GradientOrigin {
			Point get();
			void set(Point value);
		}

		property double RadiusX {
			double get();
			void set(double value);
		}

		property double RadiusY {
			double get();
			void set(double value);
		}
	};
}
