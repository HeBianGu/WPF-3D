using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageBSplineInternals
	/// </summary>
	/// <remarks>
	///    BSpline code from P. Thevenaz
	///
	/// vtkImageBSplineInternals provides code for image interpolation with
	/// b-splines of various degrees.  This code computes the coefficients
	/// from the image, and computes the weights for the b-spline kernels.
	///
	/// This class is based on code provided by Philippe Thevenaz of
	/// EPFL, Lausanne, Switzerland.  Please acknowledge his contribution
	/// by citing the following paper:
	/// [1] P. Thevenaz, T. Blu, M. Unser, "Interpolation Revisited,"
	///     IEEE Transactions on Medical Imaging 19(7):739-758, 2000.
	///
	/// The clamped boundary condition (which is the default) is taken
	/// from code presented in the following paper:
	/// [2] D. Ruijters, P. Thevenaz,
	///     "GPU Prefilter for Accurate Cubic B-spline Interpolation,"
	///     The Computer Journal, doi: 10.1093/comjnl/bxq086, 2010.
	/// </remarks>
	// Token: 0x0200084F RID: 2127
	public class vtkImageBSplineInternals : WrappedObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601611D RID: 90397 RVA: 0x001F140A File Offset: 0x001EF60A
		static vtkImageBSplineInternals()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageBSplineInternals.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageBSplineInternals"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601611E RID: 90398 RVA: 0x001F1432 File Offset: 0x001EF632
		public vtkImageBSplineInternals(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601611F RID: 90399 RVA: 0x001F1440 File Offset: 0x001EF640
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016120 RID: 90400
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageBSplineInternals_ConvertToInterpolationCoefficients_01(IntPtr data, int size, vtkImageBorderMode border, IntPtr poles, int numPoles, double tol);

		/// <summary>
		/// Internal method.  Compute the coefficients for one row of data.
		/// </summary>
		// Token: 0x06016121 RID: 90401 RVA: 0x001F144B File Offset: 0x001EF64B
		public static void ConvertToInterpolationCoefficients(IntPtr data, int size, vtkImageBorderMode border, IntPtr poles, int numPoles, double tol)
		{
			vtkImageBSplineInternals.vtkImageBSplineInternals_ConvertToInterpolationCoefficients_01(data, size, border, poles, numPoles, tol);
		}

		// Token: 0x06016122 RID: 90402
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageBSplineInternals_GetInterpolationWeights_02(IntPtr weights, double w, int degree);

		/// <summary>
		/// Internal method.  Get interpolation weights for offset w, where
		/// w is between 0 and 1.  You must provide the degree of the spline.
		/// </summary>
		// Token: 0x06016123 RID: 90403 RVA: 0x001F145C File Offset: 0x001EF65C
		public static int GetInterpolationWeights(IntPtr weights, double w, int degree)
		{
			return vtkImageBSplineInternals.vtkImageBSplineInternals_GetInterpolationWeights_02(weights, w, degree);
		}

		// Token: 0x06016124 RID: 90404
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageBSplineInternals_GetPoleValues_03(IntPtr poles, ref int numPoles, int degree);

		/// <summary>
		/// Internal method.  Get the poles for spline of given degree.
		/// Returns zero if an illegal degree is given (allowed range 2 to 9).
		/// The parameter numPoles will be set to a value between 1 and 4.
		/// </summary>
		// Token: 0x06016125 RID: 90405 RVA: 0x001F1478 File Offset: 0x001EF678
		public static int GetPoleValues(IntPtr poles, ref int numPoles, int degree)
		{
			return vtkImageBSplineInternals.vtkImageBSplineInternals_GetPoleValues_03(poles, ref numPoles, degree);
		}

		// Token: 0x06016126 RID: 90406
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageBSplineInternals_InterpolatedValue_04(IntPtr coeffs, IntPtr value, int width, int height, int slices, int depth, double x, double y, double z, int degree, vtkImageBorderMode border);

		/// <summary>
		/// Internal method.  Interpolate a value from the supplied 3D array
		/// of coefficients with dimensions width x height x slices.
		/// </summary>
		// Token: 0x06016127 RID: 90407 RVA: 0x001F1494 File Offset: 0x001EF694
		public static int InterpolatedValue(IntPtr coeffs, IntPtr value, int width, int height, int slices, int depth, double x, double y, double z, int degree, vtkImageBorderMode border)
		{
			return vtkImageBSplineInternals.vtkImageBSplineInternals_InterpolatedValue_04(coeffs, value, width, height, slices, depth, x, y, z, degree, border);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018F2 RID: 6386
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageBSplineInternals";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018F3 RID: 6387
		public new static readonly string MRClassNameKey = "class vtkImageBSplineInternals";
	}
}
