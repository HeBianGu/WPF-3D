using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkGeodesicPath
	/// </summary>
	/// <remarks>
	///    Abstract base for classes that generate a geodesic path
	///
	/// Serves as a base class for algorithms that trace a geodesic path on a
	/// polygonal dataset.
	/// </remarks>
	// Token: 0x02000550 RID: 1360
	public class vtkGeodesicPath : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600F211 RID: 61969 RVA: 0x00151341 File Offset: 0x0014F541
		static vtkGeodesicPath()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkGeodesicPath.MRClassNameKey, Type.GetType("Kitware.VTK.vtkGeodesicPath"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600F212 RID: 61970 RVA: 0x00151369 File Offset: 0x0014F569
		public vtkGeodesicPath(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600F213 RID: 61971 RVA: 0x00151377 File Offset: 0x0014F577
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600F214 RID: 61972
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGeodesicPath_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for printing and determining type information.
		/// </summary>
		// Token: 0x0600F215 RID: 61973 RVA: 0x00151384 File Offset: 0x0014F584
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkGeodesicPath.vtkGeodesicPath_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600F216 RID: 61974
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkGeodesicPath_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for printing and determining type information.
		/// </summary>
		// Token: 0x0600F217 RID: 61975 RVA: 0x001513A4 File Offset: 0x0014F5A4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkGeodesicPath.vtkGeodesicPath_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600F218 RID: 61976
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeodesicPath_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for printing and determining type information.
		/// </summary>
		// Token: 0x0600F219 RID: 61977 RVA: 0x001513C0 File Offset: 0x0014F5C0
		public override int IsA(string type)
		{
			return vtkGeodesicPath.vtkGeodesicPath_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600F21A RID: 61978
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkGeodesicPath_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for printing and determining type information.
		/// </summary>
		// Token: 0x0600F21B RID: 61979 RVA: 0x001513E0 File Offset: 0x0014F5E0
		public new static int IsTypeOf(string type)
		{
			return vtkGeodesicPath.vtkGeodesicPath_IsTypeOf_04(type);
		}

		// Token: 0x0600F21C RID: 61980
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeodesicPath_NewInstance_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for printing and determining type information.
		/// </summary>
		// Token: 0x0600F21D RID: 61981 RVA: 0x001513FC File Offset: 0x0014F5FC
		public new vtkGeodesicPath NewInstance()
		{
			vtkGeodesicPath result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGeodesicPath.vtkGeodesicPath_NewInstance_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkGeodesicPath)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600F21E RID: 61982
		[DllImport("Kitware.VTK.FiltersModeling.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkGeodesicPath_SafeDownCast_06(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for printing and determining type information.
		/// </summary>
		// Token: 0x0600F21F RID: 61983 RVA: 0x00151458 File Offset: 0x0014F658
		public new static vtkGeodesicPath SafeDownCast(vtkObjectBase o)
		{
			vtkGeodesicPath vtkGeodesicPath = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkGeodesicPath.vtkGeodesicPath_SafeDownCast_06((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkGeodesicPath = (vtkGeodesicPath)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkGeodesicPath.Register(null);
				}
			}
			return vtkGeodesicPath;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400119B RID: 4507
		public new const string MRFullTypeName = "Kitware.VTK.vtkGeodesicPath";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400119C RID: 4508
		public new static readonly string MRClassNameKey = "class vtkGeodesicPath";
	}
}
