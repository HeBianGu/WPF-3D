using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkClipConvexPolyData
	/// </summary>
	/// <remarks>
	///    clip any dataset with user-specified implicit function or input scalar data
	///
	/// vtkClipConvexPolyData is a filter that clips a convex polydata with a set
	/// of planes. Its main usage is for clipping a bounding volume with frustum
	/// planes (used later one in volume rendering).
	/// </remarks>
	// Token: 0x02000882 RID: 2178
	public class vtkClipConvexPolyData : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060169C2 RID: 92610 RVA: 0x001FCDC2 File Offset: 0x001FAFC2
		static vtkClipConvexPolyData()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkClipConvexPolyData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkClipConvexPolyData"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060169C3 RID: 92611 RVA: 0x001FCDEA File Offset: 0x001FAFEA
		public vtkClipConvexPolyData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060169C4 RID: 92612
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClipConvexPolyData_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060169C5 RID: 92613 RVA: 0x001FCDF8 File Offset: 0x001FAFF8
		public new static vtkClipConvexPolyData New()
		{
			vtkClipConvexPolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClipConvexPolyData.vtkClipConvexPolyData_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClipConvexPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060169C6 RID: 92614 RVA: 0x001FCE4C File Offset: 0x001FB04C
		public vtkClipConvexPolyData() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkClipConvexPolyData.vtkClipConvexPolyData_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060169C7 RID: 92615 RVA: 0x001FCE90 File Offset: 0x001FB090
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060169C8 RID: 92616
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkClipConvexPolyData_GetMTime_01(HandleRef pThis);

		/// <summary>
		/// Redefines this method, as this filter depends on time of its components
		/// (planes)
		/// </summary>
		// Token: 0x060169C9 RID: 92617 RVA: 0x001FCE9C File Offset: 0x001FB09C
		public override ulong GetMTime()
		{
			return vtkClipConvexPolyData.vtkClipConvexPolyData_GetMTime_01(base.GetCppThis());
		}

		// Token: 0x060169CA RID: 92618
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkClipConvexPolyData_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060169CB RID: 92619 RVA: 0x001FCEBC File Offset: 0x001FB0BC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkClipConvexPolyData.vtkClipConvexPolyData_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x060169CC RID: 92620
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkClipConvexPolyData_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060169CD RID: 92621 RVA: 0x001FCEDC File Offset: 0x001FB0DC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkClipConvexPolyData.vtkClipConvexPolyData_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x060169CE RID: 92622
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClipConvexPolyData_GetPlanes_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set all the planes at once using a vtkPlanes implicit function.
		/// This also sets the D value.
		/// </summary>
		// Token: 0x060169CF RID: 92623 RVA: 0x001FCEF8 File Offset: 0x001FB0F8
		public virtual vtkPlaneCollection GetPlanes()
		{
			vtkPlaneCollection vtkPlaneCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClipConvexPolyData.vtkClipConvexPolyData_GetPlanes_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPlaneCollection = (vtkPlaneCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPlaneCollection.Register(null);
				}
			}
			return vtkPlaneCollection;
		}

		// Token: 0x060169D0 RID: 92624
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClipConvexPolyData_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060169D1 RID: 92625 RVA: 0x001FCF68 File Offset: 0x001FB168
		public override int IsA(string type)
		{
			return vtkClipConvexPolyData.vtkClipConvexPolyData_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060169D2 RID: 92626
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClipConvexPolyData_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060169D3 RID: 92627 RVA: 0x001FCF88 File Offset: 0x001FB188
		public new static int IsTypeOf(string type)
		{
			return vtkClipConvexPolyData.vtkClipConvexPolyData_IsTypeOf_06(type);
		}

		// Token: 0x060169D4 RID: 92628
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClipConvexPolyData_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060169D5 RID: 92629 RVA: 0x001FCFA4 File Offset: 0x001FB1A4
		public new vtkClipConvexPolyData NewInstance()
		{
			vtkClipConvexPolyData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClipConvexPolyData.vtkClipConvexPolyData_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClipConvexPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060169D6 RID: 92630
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClipConvexPolyData_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060169D7 RID: 92631 RVA: 0x001FD000 File Offset: 0x001FB200
		public new static vtkClipConvexPolyData SafeDownCast(vtkObjectBase o)
		{
			vtkClipConvexPolyData vtkClipConvexPolyData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClipConvexPolyData.vtkClipConvexPolyData_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkClipConvexPolyData = (vtkClipConvexPolyData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkClipConvexPolyData.Register(null);
				}
			}
			return vtkClipConvexPolyData;
		}

		// Token: 0x060169D8 RID: 92632
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClipConvexPolyData_SetPlanes_10(HandleRef pThis, HandleRef planes);

		/// <summary>
		/// Set all the planes at once using a vtkPlanes implicit function.
		/// This also sets the D value.
		/// </summary>
		// Token: 0x060169D9 RID: 92633 RVA: 0x001FD080 File Offset: 0x001FB280
		public void SetPlanes(vtkPlaneCollection planes)
		{
			vtkClipConvexPolyData.vtkClipConvexPolyData_SetPlanes_10(base.GetCppThis(), (planes == null) ? default(HandleRef) : planes.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001965 RID: 6501
		public new const string MRFullTypeName = "Kitware.VTK.vtkClipConvexPolyData";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001966 RID: 6502
		public new static readonly string MRClassNameKey = "class vtkClipConvexPolyData";
	}
}
