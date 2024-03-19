using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImagePointIterator
	/// </summary>
	/// <remarks>
	///    iterate over all data points in an image.
	///
	/// This class will iterate over an image.  For each position, it provides
	/// the (x,y,z) position, the (I,J,K) index, and the point Id.  If a stencil
	/// is provided, then it also reports, for each point, whether the point is
	/// inside the stencil.
	/// &lt;p&gt;The iterator can go through the image point-by-point or span-by-span.
	/// The Next() method advances to the next point, while the NextSpan() method
	/// skips to the beginning of the next span, where a span is defined as a
	/// start position and point count within an image row.
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageData vtkImageStencilData vtkImageProgressIterator
	/// </seealso>
	// Token: 0x0200085F RID: 2143
	public class vtkImagePointIterator : vtkImagePointDataIterator
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016371 RID: 90993 RVA: 0x001F45CF File Offset: 0x001F27CF
		static vtkImagePointIterator()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImagePointIterator.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImagePointIterator"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016372 RID: 90994 RVA: 0x001F45F7 File Offset: 0x001F27F7
		public vtkImagePointIterator(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016373 RID: 90995 RVA: 0x001F4605 File Offset: 0x001F2805
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016374 RID: 90996
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImagePointIterator_GetPosition_01(HandleRef pThis);

		/// <summary>
		/// Get the current position.
		/// </summary>
		// Token: 0x06016375 RID: 90997 RVA: 0x001F4610 File Offset: 0x001F2810
		public double[] GetPosition()
		{
			IntPtr intPtr = vtkImagePointIterator.vtkImagePointIterator_GetPosition_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06016376 RID: 90998
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePointIterator_GetPosition_02(HandleRef pThis, IntPtr x);

		/// <summary>
		/// Get the current position and place it in the provided array.
		/// </summary>
		// Token: 0x06016377 RID: 90999 RVA: 0x001F4658 File Offset: 0x001F2858
		public void GetPosition(IntPtr x)
		{
			vtkImagePointIterator.vtkImagePointIterator_GetPosition_02(base.GetCppThis(), x);
		}

		// Token: 0x06016378 RID: 91000
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePointIterator_Initialize_03(HandleRef pThis, HandleRef image, IntPtr extent, HandleRef stencil, HandleRef algorithm, int threadId);

		/// <summary>
		/// Initialize an iterator.  See constructor for more details.
		/// </summary>
		// Token: 0x06016379 RID: 91001 RVA: 0x001F4668 File Offset: 0x001F2868
		public new void Initialize(vtkImageData image, IntPtr extent, vtkImageStencilData stencil, vtkAlgorithm algorithm, int threadId)
		{
			vtkImagePointIterator.vtkImagePointIterator_Initialize_03(base.GetCppThis(), (image == null) ? default(HandleRef) : image.GetCppThis(), extent, (stencil == null) ? default(HandleRef) : stencil.GetCppThis(), (algorithm == null) ? default(HandleRef) : algorithm.GetCppThis(), threadId);
		}

		// Token: 0x0601637A RID: 91002
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkImagePointIterator_IsAtEnd_04(HandleRef pThis);

		/// <summary>
		/// Test if the iterator has completed iterating over the entire extent.
		/// </summary>
		// Token: 0x0601637B RID: 91003 RVA: 0x001F46C8 File Offset: 0x001F28C8
		public new bool IsAtEnd()
		{
			return vtkImagePointIterator.vtkImagePointIterator_IsAtEnd_04(base.GetCppThis()) != 0;
		}

		// Token: 0x0601637C RID: 91004
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePointIterator_Next_05(HandleRef pThis);

		/// <summary>
		/// Move to the next position (rather than directly to the next span).
		/// This will automatically advance to the next span if the end of the
		/// current span is reached.
		/// </summary>
		// Token: 0x0601637D RID: 91005 RVA: 0x001F46EE File Offset: 0x001F28EE
		public void Next()
		{
			vtkImagePointIterator.vtkImagePointIterator_Next_05(base.GetCppThis());
		}

		// Token: 0x0601637E RID: 91006
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImagePointIterator_NextSpan_06(HandleRef pThis);

		/// <summary>
		/// Move the iterator to the beginning of the next span.
		/// A span is a contiguous region of the image over which nothing but
		/// the point Id and the X index changes.
		/// </summary>
		// Token: 0x0601637F RID: 91007 RVA: 0x001F46FD File Offset: 0x001F28FD
		public new void NextSpan()
		{
			vtkImagePointIterator.vtkImagePointIterator_NextSpan_06(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001912 RID: 6418
		public new const string MRFullTypeName = "Kitware.VTK.vtkImagePointIterator";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001913 RID: 6419
		public new static readonly string MRClassNameKey = "class vtkImagePointIterator";
	}
}
