using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkVoxelContoursToSurfaceFilter
	/// </summary>
	/// <remarks>
	///    create surface from contours
	///
	/// vtkVoxelContoursToSurfaceFilter is a filter that takes contours and
	/// produces surfaces. There are some restrictions for the contours:
	///
	///   - The contours are input as vtkPolyData, with the contours being
	///     polys in the vtkPolyData.
	///   - The contours lie on XY planes - each contour has a constant Z
	///   - The contours are ordered in the polys of the vtkPolyData such
	///     that all contours on the first (lowest) XY plane are first, then
	///     continuing in order of increasing Z value.
	///   - The X, Y and Z coordinates are all integer values.
	///   - The desired sampling of the contour data is 1x1x1 - Aspect can
	///     be used to control the aspect ratio in the output polygonal
	///     dataset.
	///
	/// This filter takes the contours and produces a structured points
	/// dataset of signed floating point number indicating distance from
	/// a contour. A contouring filter is then applied to generate 3D
	/// surfaces from a stack of 2D contour distance slices. This is
	/// done in a streaming fashion so as not to use to much memory.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPolyDataAlgorithm
	/// </seealso>
	// Token: 0x020008F8 RID: 2296
	public class vtkVoxelContoursToSurfaceFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017B55 RID: 97109 RVA: 0x00213F5B File Offset: 0x0021215B
		static vtkVoxelContoursToSurfaceFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkVoxelContoursToSurfaceFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkVoxelContoursToSurfaceFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017B56 RID: 97110 RVA: 0x00213F83 File Offset: 0x00212183
		public vtkVoxelContoursToSurfaceFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017B57 RID: 97111
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoxelContoursToSurfaceFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017B58 RID: 97112 RVA: 0x00213F94 File Offset: 0x00212194
		public new static vtkVoxelContoursToSurfaceFilter New()
		{
			vtkVoxelContoursToSurfaceFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVoxelContoursToSurfaceFilter.vtkVoxelContoursToSurfaceFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVoxelContoursToSurfaceFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017B59 RID: 97113 RVA: 0x00213FE8 File Offset: 0x002121E8
		public vtkVoxelContoursToSurfaceFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkVoxelContoursToSurfaceFilter.vtkVoxelContoursToSurfaceFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06017B5A RID: 97114 RVA: 0x0021402C File Offset: 0x0021222C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06017B5B RID: 97115
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoxelContoursToSurfaceFilter_GetMemoryLimitInBytes_01(HandleRef pThis);

		/// <summary>
		/// Set / Get the memory limit in bytes for this filter. This is the limit
		/// of the size of the structured points data set that is created for
		/// intermediate processing. The data will be streamed through this volume
		/// in as many pieces as necessary.
		/// </summary>
		// Token: 0x06017B5C RID: 97116 RVA: 0x00214038 File Offset: 0x00212238
		public virtual int GetMemoryLimitInBytes()
		{
			return vtkVoxelContoursToSurfaceFilter.vtkVoxelContoursToSurfaceFilter_GetMemoryLimitInBytes_01(base.GetCppThis());
		}

		// Token: 0x06017B5D RID: 97117
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVoxelContoursToSurfaceFilter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017B5E RID: 97118 RVA: 0x00214058 File Offset: 0x00212258
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkVoxelContoursToSurfaceFilter.vtkVoxelContoursToSurfaceFilter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06017B5F RID: 97119
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkVoxelContoursToSurfaceFilter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017B60 RID: 97120 RVA: 0x00214078 File Offset: 0x00212278
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkVoxelContoursToSurfaceFilter.vtkVoxelContoursToSurfaceFilter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06017B61 RID: 97121
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoxelContoursToSurfaceFilter_GetSpacing_04(HandleRef pThis);

		/// <summary>
		/// Set / Get the memory limit in bytes for this filter. This is the limit
		/// of the size of the structured points data set that is created for
		/// intermediate processing. The data will be streamed through this volume
		/// in as many pieces as necessary.
		/// </summary>
		// Token: 0x06017B62 RID: 97122 RVA: 0x00214094 File Offset: 0x00212294
		public virtual double[] GetSpacing()
		{
			IntPtr intPtr = vtkVoxelContoursToSurfaceFilter.vtkVoxelContoursToSurfaceFilter_GetSpacing_04(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06017B63 RID: 97123
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelContoursToSurfaceFilter_GetSpacing_05(HandleRef pThis, IntPtr data);

		/// <summary>
		/// Set / Get the memory limit in bytes for this filter. This is the limit
		/// of the size of the structured points data set that is created for
		/// intermediate processing. The data will be streamed through this volume
		/// in as many pieces as necessary.
		/// </summary>
		// Token: 0x06017B64 RID: 97124 RVA: 0x002140DC File Offset: 0x002122DC
		public virtual void GetSpacing(IntPtr data)
		{
			vtkVoxelContoursToSurfaceFilter.vtkVoxelContoursToSurfaceFilter_GetSpacing_05(base.GetCppThis(), data);
		}

		// Token: 0x06017B65 RID: 97125
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoxelContoursToSurfaceFilter_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017B66 RID: 97126 RVA: 0x002140EC File Offset: 0x002122EC
		public override int IsA(string type)
		{
			return vtkVoxelContoursToSurfaceFilter.vtkVoxelContoursToSurfaceFilter_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06017B67 RID: 97127
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkVoxelContoursToSurfaceFilter_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017B68 RID: 97128 RVA: 0x0021410C File Offset: 0x0021230C
		public new static int IsTypeOf(string type)
		{
			return vtkVoxelContoursToSurfaceFilter.vtkVoxelContoursToSurfaceFilter_IsTypeOf_07(type);
		}

		// Token: 0x06017B69 RID: 97129
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoxelContoursToSurfaceFilter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017B6A RID: 97130 RVA: 0x00214128 File Offset: 0x00212328
		public new vtkVoxelContoursToSurfaceFilter NewInstance()
		{
			vtkVoxelContoursToSurfaceFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVoxelContoursToSurfaceFilter.vtkVoxelContoursToSurfaceFilter_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVoxelContoursToSurfaceFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017B6B RID: 97131
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkVoxelContoursToSurfaceFilter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017B6C RID: 97132 RVA: 0x00214184 File Offset: 0x00212384
		public new static vtkVoxelContoursToSurfaceFilter SafeDownCast(vtkObjectBase o)
		{
			vtkVoxelContoursToSurfaceFilter vtkVoxelContoursToSurfaceFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkVoxelContoursToSurfaceFilter.vtkVoxelContoursToSurfaceFilter_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkVoxelContoursToSurfaceFilter = (vtkVoxelContoursToSurfaceFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkVoxelContoursToSurfaceFilter.Register(null);
				}
			}
			return vtkVoxelContoursToSurfaceFilter;
		}

		// Token: 0x06017B6D RID: 97133
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelContoursToSurfaceFilter_SetMemoryLimitInBytes_11(HandleRef pThis, int _arg);

		/// <summary>
		/// Set / Get the memory limit in bytes for this filter. This is the limit
		/// of the size of the structured points data set that is created for
		/// intermediate processing. The data will be streamed through this volume
		/// in as many pieces as necessary.
		/// </summary>
		// Token: 0x06017B6E RID: 97134 RVA: 0x00214203 File Offset: 0x00212403
		public virtual void SetMemoryLimitInBytes(int _arg)
		{
			vtkVoxelContoursToSurfaceFilter.vtkVoxelContoursToSurfaceFilter_SetMemoryLimitInBytes_11(base.GetCppThis(), _arg);
		}

		// Token: 0x06017B6F RID: 97135
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelContoursToSurfaceFilter_SetSpacing_12(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		/// Set / Get the memory limit in bytes for this filter. This is the limit
		/// of the size of the structured points data set that is created for
		/// intermediate processing. The data will be streamed through this volume
		/// in as many pieces as necessary.
		/// </summary>
		// Token: 0x06017B70 RID: 97136 RVA: 0x00214213 File Offset: 0x00212413
		public virtual void SetSpacing(double _arg1, double _arg2, double _arg3)
		{
			vtkVoxelContoursToSurfaceFilter.vtkVoxelContoursToSurfaceFilter_SetSpacing_12(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x06017B71 RID: 97137
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkVoxelContoursToSurfaceFilter_SetSpacing_13(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set / Get the memory limit in bytes for this filter. This is the limit
		/// of the size of the structured points data set that is created for
		/// intermediate processing. The data will be streamed through this volume
		/// in as many pieces as necessary.
		/// </summary>
		// Token: 0x06017B72 RID: 97138 RVA: 0x00214225 File Offset: 0x00212425
		public virtual void SetSpacing(IntPtr _arg)
		{
			vtkVoxelContoursToSurfaceFilter.vtkVoxelContoursToSurfaceFilter_SetSpacing_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A6F RID: 6767
		public new const string MRFullTypeName = "Kitware.VTK.vtkVoxelContoursToSurfaceFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A70 RID: 6768
		public new static readonly string MRClassNameKey = "class vtkVoxelContoursToSurfaceFilter";
	}
}
