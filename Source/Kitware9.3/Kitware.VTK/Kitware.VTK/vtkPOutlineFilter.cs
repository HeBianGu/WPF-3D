using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPOutlineFilter
	/// </summary>
	/// <remarks>
	///    create wireframe outline for arbitrary data set
	///
	/// vtkPOutlineFilter works like vtkOutlineFilter, but it looks for data
	/// partitions in other processes.  It assumes the filter is operated
	/// in a data parallel pipeline.
	/// </remarks>
	// Token: 0x02000522 RID: 1314
	public class vtkPOutlineFilter : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600EB18 RID: 60184 RVA: 0x00147E7B File Offset: 0x0014607B
		static vtkPOutlineFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPOutlineFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPOutlineFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600EB19 RID: 60185 RVA: 0x00147EA3 File Offset: 0x001460A3
		public vtkPOutlineFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600EB1A RID: 60186
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPOutlineFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EB1B RID: 60187 RVA: 0x00147EB4 File Offset: 0x001460B4
		public new static vtkPOutlineFilter New()
		{
			vtkPOutlineFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPOutlineFilter.vtkPOutlineFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPOutlineFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EB1C RID: 60188 RVA: 0x00147F08 File Offset: 0x00146108
		public vtkPOutlineFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPOutlineFilter.vtkPOutlineFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600EB1D RID: 60189 RVA: 0x00147F4C File Offset: 0x0014614C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600EB1E RID: 60190
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPOutlineFilter_GetController_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set and get the controller.
		/// </summary>
		// Token: 0x0600EB1F RID: 60191 RVA: 0x00147F58 File Offset: 0x00146158
		public virtual vtkMultiProcessController GetController()
		{
			vtkMultiProcessController vtkMultiProcessController = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPOutlineFilter.vtkPOutlineFilter_GetController_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMultiProcessController = (vtkMultiProcessController)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMultiProcessController.Register(null);
				}
			}
			return vtkMultiProcessController;
		}

		// Token: 0x0600EB20 RID: 60192
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPOutlineFilter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EB21 RID: 60193 RVA: 0x00147FC8 File Offset: 0x001461C8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPOutlineFilter.vtkPOutlineFilter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600EB22 RID: 60194
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPOutlineFilter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EB23 RID: 60195 RVA: 0x00147FE8 File Offset: 0x001461E8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPOutlineFilter.vtkPOutlineFilter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600EB24 RID: 60196
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPOutlineFilter_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EB25 RID: 60197 RVA: 0x00148004 File Offset: 0x00146204
		public override int IsA(string type)
		{
			return vtkPOutlineFilter.vtkPOutlineFilter_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0600EB26 RID: 60198
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPOutlineFilter_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EB27 RID: 60199 RVA: 0x00148024 File Offset: 0x00146224
		public new static int IsTypeOf(string type)
		{
			return vtkPOutlineFilter.vtkPOutlineFilter_IsTypeOf_05(type);
		}

		// Token: 0x0600EB28 RID: 60200
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPOutlineFilter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EB29 RID: 60201 RVA: 0x00148040 File Offset: 0x00146240
		public new vtkPOutlineFilter NewInstance()
		{
			vtkPOutlineFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPOutlineFilter.vtkPOutlineFilter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPOutlineFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600EB2A RID: 60202
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPOutlineFilter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600EB2B RID: 60203 RVA: 0x0014809C File Offset: 0x0014629C
		public new static vtkPOutlineFilter SafeDownCast(vtkObjectBase o)
		{
			vtkPOutlineFilter vtkPOutlineFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPOutlineFilter.vtkPOutlineFilter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPOutlineFilter = (vtkPOutlineFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPOutlineFilter.Register(null);
				}
			}
			return vtkPOutlineFilter;
		}

		// Token: 0x0600EB2C RID: 60204
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPOutlineFilter_SetController_09(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set and get the controller.
		/// </summary>
		// Token: 0x0600EB2D RID: 60205 RVA: 0x0014811C File Offset: 0x0014631C
		public virtual void SetController(vtkMultiProcessController arg0)
		{
			vtkPOutlineFilter.vtkPOutlineFilter_SetController_09(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001133 RID: 4403
		public new const string MRFullTypeName = "Kitware.VTK.vtkPOutlineFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001134 RID: 4404
		public new static readonly string MRClassNameKey = "class vtkPOutlineFilter";
	}
}
