using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkStreaklineFilter
	/// </summary>
	/// <remarks>
	///    A Parallel Particle tracer for unsteady vector fields
	///
	/// vtkStreaklineFilter is a filter that integrates a vector field to generate streak lines
	///
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkParticleTracerBase has the details of the algorithms
	/// </seealso>
	// Token: 0x020004BE RID: 1214
	public class vtkStreaklineFilter : vtkParticleTracerBase
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600DE73 RID: 56947 RVA: 0x00134C0B File Offset: 0x00132E0B
		static vtkStreaklineFilter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkStreaklineFilter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkStreaklineFilter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600DE74 RID: 56948 RVA: 0x00134C33 File Offset: 0x00132E33
		public vtkStreaklineFilter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600DE75 RID: 56949
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreaklineFilter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DE76 RID: 56950 RVA: 0x00134C44 File Offset: 0x00132E44
		public new static vtkStreaklineFilter New()
		{
			vtkStreaklineFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreaklineFilter.vtkStreaklineFilter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStreaklineFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DE77 RID: 56951 RVA: 0x00134C98 File Offset: 0x00132E98
		public vtkStreaklineFilter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkStreaklineFilter.vtkStreaklineFilter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600DE78 RID: 56952 RVA: 0x00134CDC File Offset: 0x00132EDC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600DE79 RID: 56953
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStreaklineFilter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DE7A RID: 56954 RVA: 0x00134CE8 File Offset: 0x00132EE8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkStreaklineFilter.vtkStreaklineFilter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600DE7B RID: 56955
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkStreaklineFilter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DE7C RID: 56956 RVA: 0x00134D08 File Offset: 0x00132F08
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkStreaklineFilter.vtkStreaklineFilter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600DE7D RID: 56957
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStreaklineFilter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DE7E RID: 56958 RVA: 0x00134D24 File Offset: 0x00132F24
		public override int IsA(string type)
		{
			return vtkStreaklineFilter.vtkStreaklineFilter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600DE7F RID: 56959
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkStreaklineFilter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DE80 RID: 56960 RVA: 0x00134D44 File Offset: 0x00132F44
		public new static int IsTypeOf(string type)
		{
			return vtkStreaklineFilter.vtkStreaklineFilter_IsTypeOf_04(type);
		}

		// Token: 0x0600DE81 RID: 56961
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreaklineFilter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DE82 RID: 56962 RVA: 0x00134D60 File Offset: 0x00132F60
		public new vtkStreaklineFilter NewInstance()
		{
			vtkStreaklineFilter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreaklineFilter.vtkStreaklineFilter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkStreaklineFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600DE83 RID: 56963
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkStreaklineFilter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600DE84 RID: 56964 RVA: 0x00134DBC File Offset: 0x00132FBC
		public new static vtkStreaklineFilter SafeDownCast(vtkObjectBase o)
		{
			vtkStreaklineFilter vtkStreaklineFilter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkStreaklineFilter.vtkStreaklineFilter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkStreaklineFilter = (vtkStreaklineFilter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkStreaklineFilter.Register(null);
				}
			}
			return vtkStreaklineFilter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001043 RID: 4163
		public new const string MRFullTypeName = "Kitware.VTK.vtkStreaklineFilter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001044 RID: 4164
		public new static readonly string MRClassNameKey = "class vtkStreaklineFilter";
	}
}
