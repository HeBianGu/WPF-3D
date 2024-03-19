using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageToPoints
	/// </summary>
	/// <remarks>
	///    Extract all image voxels as points.
	///
	/// This filter takes an input image and an optional stencil, and creates
	/// a vtkPolyData that contains the points and the point attributes but no
	/// cells.  If a stencil is provided, only the points inside the stencil
	/// are included.
	/// @par Thanks:
	/// Thanks to David Gobbi, Calgary Image Processing and Analysis Centre,
	/// University of Calgary, for providing this class.
	/// </remarks>
	// Token: 0x020003E5 RID: 997
	public class vtkImageToPoints : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600BF0F RID: 48911 RVA: 0x0010A42D File Offset: 0x0010862D
		static vtkImageToPoints()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageToPoints.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageToPoints"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600BF10 RID: 48912 RVA: 0x0010A455 File Offset: 0x00108655
		public vtkImageToPoints(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600BF11 RID: 48913
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageToPoints_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BF12 RID: 48914 RVA: 0x0010A464 File Offset: 0x00108664
		public new static vtkImageToPoints New()
		{
			vtkImageToPoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageToPoints.vtkImageToPoints_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageToPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BF13 RID: 48915 RVA: 0x0010A4B8 File Offset: 0x001086B8
		public vtkImageToPoints() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageToPoints.vtkImageToPoints_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600BF14 RID: 48916 RVA: 0x0010A4FC File Offset: 0x001086FC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600BF15 RID: 48917
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageToPoints_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BF16 RID: 48918 RVA: 0x0010A508 File Offset: 0x00108708
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageToPoints.vtkImageToPoints_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600BF17 RID: 48919
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageToPoints_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BF18 RID: 48920 RVA: 0x0010A528 File Offset: 0x00108728
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageToPoints.vtkImageToPoints_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600BF19 RID: 48921
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToPoints_GetOutputPointsPrecision_03(HandleRef pThis);

		/// <summary>
		/// Set the desired precision for the output points.
		/// See vtkAlgorithm::DesiredOutputPrecision for the available choices.
		/// The default is double precision.
		/// </summary>
		// Token: 0x0600BF1A RID: 48922 RVA: 0x0010A544 File Offset: 0x00108744
		public virtual int GetOutputPointsPrecision()
		{
			return vtkImageToPoints.vtkImageToPoints_GetOutputPointsPrecision_03(base.GetCppThis());
		}

		// Token: 0x0600BF1B RID: 48923
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageToPoints_GetStencilConnection_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Only extract the points that lie within the stencil.
		/// </summary>
		// Token: 0x0600BF1C RID: 48924 RVA: 0x0010A564 File Offset: 0x00108764
		public vtkAlgorithmOutput GetStencilConnection()
		{
			vtkAlgorithmOutput vtkAlgorithmOutput = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageToPoints.vtkImageToPoints_GetStencilConnection_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAlgorithmOutput = (vtkAlgorithmOutput)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAlgorithmOutput.Register(null);
				}
			}
			return vtkAlgorithmOutput;
		}

		// Token: 0x0600BF1D RID: 48925
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToPoints_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BF1E RID: 48926 RVA: 0x0010A5D4 File Offset: 0x001087D4
		public override int IsA(string type)
		{
			return vtkImageToPoints.vtkImageToPoints_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600BF1F RID: 48927
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageToPoints_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BF20 RID: 48928 RVA: 0x0010A5F4 File Offset: 0x001087F4
		public new static int IsTypeOf(string type)
		{
			return vtkImageToPoints.vtkImageToPoints_IsTypeOf_06(type);
		}

		// Token: 0x0600BF21 RID: 48929
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageToPoints_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BF22 RID: 48930 RVA: 0x0010A610 File Offset: 0x00108810
		public new vtkImageToPoints NewInstance()
		{
			vtkImageToPoints result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageToPoints.vtkImageToPoints_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageToPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600BF23 RID: 48931
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageToPoints_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600BF24 RID: 48932 RVA: 0x0010A66C File Offset: 0x0010886C
		public new static vtkImageToPoints SafeDownCast(vtkObjectBase o)
		{
			vtkImageToPoints vtkImageToPoints = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageToPoints.vtkImageToPoints_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageToPoints = (vtkImageToPoints)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageToPoints.Register(null);
				}
			}
			return vtkImageToPoints;
		}

		// Token: 0x0600BF25 RID: 48933
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageToPoints_SetOutputPointsPrecision_10(HandleRef pThis, int _arg);

		/// <summary>
		/// Set the desired precision for the output points.
		/// See vtkAlgorithm::DesiredOutputPrecision for the available choices.
		/// The default is double precision.
		/// </summary>
		// Token: 0x0600BF26 RID: 48934 RVA: 0x0010A6EB File Offset: 0x001088EB
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkImageToPoints.vtkImageToPoints_SetOutputPointsPrecision_10(base.GetCppThis(), _arg);
		}

		// Token: 0x0600BF27 RID: 48935
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageToPoints_SetStencilConnection_11(HandleRef pThis, HandleRef port);

		/// <summary>
		/// Only extract the points that lie within the stencil.
		/// </summary>
		// Token: 0x0600BF28 RID: 48936 RVA: 0x0010A6FC File Offset: 0x001088FC
		public void SetStencilConnection(vtkAlgorithmOutput port)
		{
			vtkImageToPoints.vtkImageToPoints_SetStencilConnection_11(base.GetCppThis(), (port == null) ? default(HandleRef) : port.GetCppThis());
		}

		// Token: 0x0600BF29 RID: 48937
		[DllImport("Kitware.VTK.ImagingHybrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageToPoints_SetStencilData_12(HandleRef pThis, HandleRef stencil);

		/// <summary>
		/// Only extract the points that lie within the stencil.
		/// </summary>
		// Token: 0x0600BF2A RID: 48938 RVA: 0x0010A72C File Offset: 0x0010892C
		public void SetStencilData(vtkImageStencilData stencil)
		{
			vtkImageToPoints.vtkImageToPoints_SetStencilData_12(base.GetCppThis(), (stencil == null) ? default(HandleRef) : stencil.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E37 RID: 3639
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageToPoints";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000E38 RID: 3640
		public new static readonly string MRClassNameKey = "class vtkImageToPoints";
	}
}
