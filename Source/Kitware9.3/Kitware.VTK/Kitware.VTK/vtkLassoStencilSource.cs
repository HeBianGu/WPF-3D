using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkLassoStencilSource
	/// </summary>
	/// <remarks>
	///    Create a stencil from a contour
	///
	/// vtkLassoStencilSource will create an image stencil from a
	/// set of points that define a contour.  Its output can be
	/// used with vtkImageStecil or other vtk classes that apply
	/// a stencil to an image.
	/// </remarks>
	/// <seealso>
	///
	/// vtkROIStencilSource vtkPolyDataToImageStencil
	/// @par Thanks:
	/// Thanks to David Gobbi for contributing this class to VTK.
	/// </seealso>
	// Token: 0x0200023A RID: 570
	public class vtkLassoStencilSource : vtkImageStencilSource
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006A5F RID: 27231 RVA: 0x00099BDF File Offset: 0x00097DDF
		static vtkLassoStencilSource()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkLassoStencilSource.MRClassNameKey, Type.GetType("Kitware.VTK.vtkLassoStencilSource"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006A60 RID: 27232 RVA: 0x00099C07 File Offset: 0x00097E07
		public vtkLassoStencilSource(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006A61 RID: 27233
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLassoStencilSource_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006A62 RID: 27234 RVA: 0x00099C18 File Offset: 0x00097E18
		public new static vtkLassoStencilSource New()
		{
			vtkLassoStencilSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLassoStencilSource.vtkLassoStencilSource_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLassoStencilSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006A63 RID: 27235 RVA: 0x00099C6C File Offset: 0x00097E6C
		public vtkLassoStencilSource() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkLassoStencilSource.vtkLassoStencilSource_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006A64 RID: 27236 RVA: 0x00099CB0 File Offset: 0x00097EB0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006A65 RID: 27237
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkLassoStencilSource_GetMTime_01(HandleRef pThis);

		/// <summary>
		/// Overload GetMTime() to include the timestamp on the points.
		/// </summary>
		// Token: 0x06006A66 RID: 27238 RVA: 0x00099CBC File Offset: 0x00097EBC
		public override ulong GetMTime()
		{
			return vtkLassoStencilSource.vtkLassoStencilSource_GetMTime_01(base.GetCppThis());
		}

		// Token: 0x06006A67 RID: 27239
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLassoStencilSource_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006A68 RID: 27240 RVA: 0x00099CDC File Offset: 0x00097EDC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkLassoStencilSource.vtkLassoStencilSource_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06006A69 RID: 27241
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkLassoStencilSource_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006A6A RID: 27242 RVA: 0x00099CFC File Offset: 0x00097EFC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkLassoStencilSource.vtkLassoStencilSource_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06006A6B RID: 27243
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLassoStencilSource_GetPoints_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The points that make up the lassoo.  The loop does not
		/// have to be closed, the last point will automatically be
		/// connected to the first point by a straight line segment.
		/// </summary>
		// Token: 0x06006A6C RID: 27244 RVA: 0x00099D18 File Offset: 0x00097F18
		public virtual vtkPoints GetPoints()
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLassoStencilSource.vtkLassoStencilSource_GetPoints_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		// Token: 0x06006A6D RID: 27245
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLassoStencilSource_GetShape_05(HandleRef pThis);

		/// <summary>
		/// The shape to use, default is "Polygon".  The spline is a
		/// cardinal spline.  Bezier splines are not yet supported.
		/// </summary>
		// Token: 0x06006A6E RID: 27246 RVA: 0x00099D88 File Offset: 0x00097F88
		public virtual int GetShape()
		{
			return vtkLassoStencilSource.vtkLassoStencilSource_GetShape_05(base.GetCppThis());
		}

		// Token: 0x06006A6F RID: 27247
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLassoStencilSource_GetShapeAsString_06(HandleRef pThis);

		/// <summary>
		/// The shape to use, default is "Polygon".  The spline is a
		/// cardinal spline.  Bezier splines are not yet supported.
		/// </summary>
		// Token: 0x06006A70 RID: 27248 RVA: 0x00099DA8 File Offset: 0x00097FA8
		public virtual string GetShapeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkLassoStencilSource.vtkLassoStencilSource_GetShapeAsString_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06006A71 RID: 27249
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLassoStencilSource_GetShapeMaxValue_07(HandleRef pThis);

		/// <summary>
		/// The shape to use, default is "Polygon".  The spline is a
		/// cardinal spline.  Bezier splines are not yet supported.
		/// </summary>
		// Token: 0x06006A72 RID: 27250 RVA: 0x00099DE4 File Offset: 0x00097FE4
		public virtual int GetShapeMaxValue()
		{
			return vtkLassoStencilSource.vtkLassoStencilSource_GetShapeMaxValue_07(base.GetCppThis());
		}

		// Token: 0x06006A73 RID: 27251
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLassoStencilSource_GetShapeMinValue_08(HandleRef pThis);

		/// <summary>
		/// The shape to use, default is "Polygon".  The spline is a
		/// cardinal spline.  Bezier splines are not yet supported.
		/// </summary>
		// Token: 0x06006A74 RID: 27252 RVA: 0x00099E04 File Offset: 0x00098004
		public virtual int GetShapeMinValue()
		{
			return vtkLassoStencilSource.vtkLassoStencilSource_GetShapeMinValue_08(base.GetCppThis());
		}

		// Token: 0x06006A75 RID: 27253
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLassoStencilSource_GetSliceOrientation_09(HandleRef pThis);

		/// <summary>
		/// The slice orientation.  The default is 2, which is XY.
		/// Other values are 0, which is YZ, and 1, which is XZ.
		/// </summary>
		// Token: 0x06006A76 RID: 27254 RVA: 0x00099E24 File Offset: 0x00098024
		public virtual int GetSliceOrientation()
		{
			return vtkLassoStencilSource.vtkLassoStencilSource_GetSliceOrientation_09(base.GetCppThis());
		}

		// Token: 0x06006A77 RID: 27255
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLassoStencilSource_GetSliceOrientationMaxValue_10(HandleRef pThis);

		/// <summary>
		/// The slice orientation.  The default is 2, which is XY.
		/// Other values are 0, which is YZ, and 1, which is XZ.
		/// </summary>
		// Token: 0x06006A78 RID: 27256 RVA: 0x00099E44 File Offset: 0x00098044
		public virtual int GetSliceOrientationMaxValue()
		{
			return vtkLassoStencilSource.vtkLassoStencilSource_GetSliceOrientationMaxValue_10(base.GetCppThis());
		}

		// Token: 0x06006A79 RID: 27257
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLassoStencilSource_GetSliceOrientationMinValue_11(HandleRef pThis);

		/// <summary>
		/// The slice orientation.  The default is 2, which is XY.
		/// Other values are 0, which is YZ, and 1, which is XZ.
		/// </summary>
		// Token: 0x06006A7A RID: 27258 RVA: 0x00099E64 File Offset: 0x00098064
		public virtual int GetSliceOrientationMinValue()
		{
			return vtkLassoStencilSource.vtkLassoStencilSource_GetSliceOrientationMinValue_11(base.GetCppThis());
		}

		// Token: 0x06006A7B RID: 27259
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLassoStencilSource_GetSlicePoints_12(HandleRef pThis, int i, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// The points for a particular slice.  This will override the
		/// points that were set by calling SetPoints() for the slice.
		/// To clear the setting, call SetSlicePoints(slice, nullptr).
		/// </summary>
		// Token: 0x06006A7C RID: 27260 RVA: 0x00099E84 File Offset: 0x00098084
		public virtual vtkPoints GetSlicePoints(int i)
		{
			vtkPoints vtkPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLassoStencilSource.vtkLassoStencilSource_GetSlicePoints_12(base.GetCppThis(), i, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPoints = (vtkPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPoints.Register(null);
				}
			}
			return vtkPoints;
		}

		// Token: 0x06006A7D RID: 27261
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLassoStencilSource_IsA_13(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006A7E RID: 27262 RVA: 0x00099EF4 File Offset: 0x000980F4
		public override int IsA(string type)
		{
			return vtkLassoStencilSource.vtkLassoStencilSource_IsA_13(base.GetCppThis(), type);
		}

		// Token: 0x06006A7F RID: 27263
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkLassoStencilSource_IsTypeOf_14([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006A80 RID: 27264 RVA: 0x00099F14 File Offset: 0x00098114
		public new static int IsTypeOf(string type)
		{
			return vtkLassoStencilSource.vtkLassoStencilSource_IsTypeOf_14(type);
		}

		// Token: 0x06006A81 RID: 27265
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLassoStencilSource_NewInstance_16(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006A82 RID: 27266 RVA: 0x00099F30 File Offset: 0x00098130
		public new vtkLassoStencilSource NewInstance()
		{
			vtkLassoStencilSource result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLassoStencilSource.vtkLassoStencilSource_NewInstance_16(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkLassoStencilSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006A83 RID: 27267
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLassoStencilSource_RemoveAllSlicePoints_17(HandleRef pThis);

		/// <summary>
		/// Remove points from all slices.
		/// </summary>
		// Token: 0x06006A84 RID: 27268 RVA: 0x00099F8A File Offset: 0x0009818A
		public virtual void RemoveAllSlicePoints()
		{
			vtkLassoStencilSource.vtkLassoStencilSource_RemoveAllSlicePoints_17(base.GetCppThis());
		}

		// Token: 0x06006A85 RID: 27269
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkLassoStencilSource_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006A86 RID: 27270 RVA: 0x00099F9C File Offset: 0x0009819C
		public new static vtkLassoStencilSource SafeDownCast(vtkObjectBase o)
		{
			vtkLassoStencilSource vtkLassoStencilSource = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkLassoStencilSource.vtkLassoStencilSource_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkLassoStencilSource = (vtkLassoStencilSource)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkLassoStencilSource.Register(null);
				}
			}
			return vtkLassoStencilSource;
		}

		// Token: 0x06006A87 RID: 27271
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLassoStencilSource_SetPoints_19(HandleRef pThis, HandleRef points);

		/// <summary>
		/// The points that make up the lassoo.  The loop does not
		/// have to be closed, the last point will automatically be
		/// connected to the first point by a straight line segment.
		/// </summary>
		// Token: 0x06006A88 RID: 27272 RVA: 0x0009A01C File Offset: 0x0009821C
		public virtual void SetPoints(vtkPoints points)
		{
			vtkLassoStencilSource.vtkLassoStencilSource_SetPoints_19(base.GetCppThis(), (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		// Token: 0x06006A89 RID: 27273
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLassoStencilSource_SetShape_20(HandleRef pThis, int _arg);

		/// <summary>
		/// The shape to use, default is "Polygon".  The spline is a
		/// cardinal spline.  Bezier splines are not yet supported.
		/// </summary>
		// Token: 0x06006A8A RID: 27274 RVA: 0x0009A04B File Offset: 0x0009824B
		public virtual void SetShape(int _arg)
		{
			vtkLassoStencilSource.vtkLassoStencilSource_SetShape_20(base.GetCppThis(), _arg);
		}

		// Token: 0x06006A8B RID: 27275
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLassoStencilSource_SetShapeToPolygon_21(HandleRef pThis);

		/// <summary>
		/// The shape to use, default is "Polygon".  The spline is a
		/// cardinal spline.  Bezier splines are not yet supported.
		/// </summary>
		// Token: 0x06006A8C RID: 27276 RVA: 0x0009A05B File Offset: 0x0009825B
		public void SetShapeToPolygon()
		{
			vtkLassoStencilSource.vtkLassoStencilSource_SetShapeToPolygon_21(base.GetCppThis());
		}

		// Token: 0x06006A8D RID: 27277
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLassoStencilSource_SetShapeToSpline_22(HandleRef pThis);

		/// <summary>
		/// The shape to use, default is "Polygon".  The spline is a
		/// cardinal spline.  Bezier splines are not yet supported.
		/// </summary>
		// Token: 0x06006A8E RID: 27278 RVA: 0x0009A06A File Offset: 0x0009826A
		public void SetShapeToSpline()
		{
			vtkLassoStencilSource.vtkLassoStencilSource_SetShapeToSpline_22(base.GetCppThis());
		}

		// Token: 0x06006A8F RID: 27279
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLassoStencilSource_SetSliceOrientation_23(HandleRef pThis, int _arg);

		/// <summary>
		/// The slice orientation.  The default is 2, which is XY.
		/// Other values are 0, which is YZ, and 1, which is XZ.
		/// </summary>
		// Token: 0x06006A90 RID: 27280 RVA: 0x0009A079 File Offset: 0x00098279
		public virtual void SetSliceOrientation(int _arg)
		{
			vtkLassoStencilSource.vtkLassoStencilSource_SetSliceOrientation_23(base.GetCppThis(), _arg);
		}

		// Token: 0x06006A91 RID: 27281
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkLassoStencilSource_SetSlicePoints_24(HandleRef pThis, int i, HandleRef points);

		/// <summary>
		/// The points for a particular slice.  This will override the
		/// points that were set by calling SetPoints() for the slice.
		/// To clear the setting, call SetSlicePoints(slice, nullptr).
		/// </summary>
		// Token: 0x06006A92 RID: 27282 RVA: 0x0009A08C File Offset: 0x0009828C
		public virtual void SetSlicePoints(int i, vtkPoints points)
		{
			vtkLassoStencilSource.vtkLassoStencilSource_SetSlicePoints_24(base.GetCppThis(), i, (points == null) ? default(HandleRef) : points.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400095E RID: 2398
		public new const string MRFullTypeName = "Kitware.VTK.vtkLassoStencilSource";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400095F RID: 2399
		public new static readonly string MRClassNameKey = "class vtkLassoStencilSource";

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0200023B RID: 571
		public enum POLYGON_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04000961 RID: 2401
			POLYGON,
			/// <summary>enum member</summary>
			// Token: 0x04000962 RID: 2402
			SPLINE
		}
	}
}
