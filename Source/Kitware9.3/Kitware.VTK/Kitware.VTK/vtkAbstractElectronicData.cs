using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkAbstractElectronicData
	/// </summary>
	/// <remarks>
	///    Provides access to and storage of
	/// chemical electronic data
	///
	/// </remarks>
	// Token: 0x02000627 RID: 1575
	public abstract class vtkAbstractElectronicData : vtkDataObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060110E5 RID: 69861 RVA: 0x0017C3FF File Offset: 0x0017A5FF
		static vtkAbstractElectronicData()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkAbstractElectronicData.MRClassNameKey, Type.GetType("Kitware.VTK.vtkAbstractElectronicData"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060110E6 RID: 69862 RVA: 0x0017C427 File Offset: 0x0017A627
		public vtkAbstractElectronicData(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060110E7 RID: 69863 RVA: 0x0017C435 File Offset: 0x0017A635
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060110E8 RID: 69864
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkAbstractElectronicData_DeepCopy_01(HandleRef pThis, HandleRef obj);

		/// <summary>
		/// Deep copies the data object into this.
		/// </summary>
		// Token: 0x060110E9 RID: 69865 RVA: 0x0017C440 File Offset: 0x0017A640
		public override void DeepCopy(vtkDataObject obj)
		{
			vtkAbstractElectronicData.vtkAbstractElectronicData_DeepCopy_01(base.GetCppThis(), (obj == null) ? default(HandleRef) : obj.GetCppThis());
		}

		// Token: 0x060110EA RID: 69866
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractElectronicData_GetDataObjectType_02(HandleRef pThis);

		/// <summary>
		/// Returns `VTK_ABSTRACT_ELECTRONIC_DATA`.
		/// </summary>
		// Token: 0x060110EB RID: 69867 RVA: 0x0017C470 File Offset: 0x0017A670
		public override int GetDataObjectType()
		{
			return vtkAbstractElectronicData.vtkAbstractElectronicData_GetDataObjectType_02(base.GetCppThis());
		}

		// Token: 0x060110EC RID: 69868
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractElectronicData_GetElectronDensity_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns vtkImageData for the molecule's electron density. The data
		/// will be calculated when first requested, and cached for later requests.
		/// </summary>
		// Token: 0x060110ED RID: 69869 RVA: 0x0017C490 File Offset: 0x0017A690
		public virtual vtkImageData GetElectronDensity()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractElectronicData.vtkAbstractElectronicData_GetElectronDensity_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x060110EE RID: 69870
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractElectronicData_GetHOMO_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns vtkImageData for the Highest Occupied Molecular Orbital.
		/// </summary>
		// Token: 0x060110EF RID: 69871 RVA: 0x0017C500 File Offset: 0x0017A700
		public vtkImageData GetHOMO()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractElectronicData.vtkAbstractElectronicData_GetHOMO_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x060110F0 RID: 69872
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractElectronicData_GetHOMOOrbitalNumber_05(HandleRef pThis);

		/// <summary>
		/// Returns vtkImageData for the Lowest Unoccupied Molecular Orbital.
		/// </summary>
		// Token: 0x060110F1 RID: 69873 RVA: 0x0017C570 File Offset: 0x0017A770
		public long GetHOMOOrbitalNumber()
		{
			return vtkAbstractElectronicData.vtkAbstractElectronicData_GetHOMOOrbitalNumber_05(base.GetCppThis());
		}

		// Token: 0x060110F2 RID: 69874
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractElectronicData_GetLUMO_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns vtkImageData for the Lowest Unoccupied Molecular Orbital.
		/// </summary>
		// Token: 0x060110F3 RID: 69875 RVA: 0x0017C590 File Offset: 0x0017A790
		public vtkImageData GetLUMO()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractElectronicData.vtkAbstractElectronicData_GetLUMO_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x060110F4 RID: 69876
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractElectronicData_GetLUMOOrbitalNumber_07(HandleRef pThis);

		/// <summary>
		/// Returns vtkImageData for the Lowest Unoccupied Molecular Orbital.
		/// </summary>
		// Token: 0x060110F5 RID: 69877 RVA: 0x0017C600 File Offset: 0x0017A800
		public long GetLUMOOrbitalNumber()
		{
			return vtkAbstractElectronicData.vtkAbstractElectronicData_GetLUMOOrbitalNumber_07(base.GetCppThis());
		}

		// Token: 0x060110F6 RID: 69878
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractElectronicData_GetMO_08(HandleRef pThis, long orbitalNumber, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Returns the vtkImageData for the requested molecular orbital.
		/// </summary>
		// Token: 0x060110F7 RID: 69879 RVA: 0x0017C620 File Offset: 0x0017A820
		public virtual vtkImageData GetMO(long orbitalNumber)
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractElectronicData.vtkAbstractElectronicData_GetMO_08(base.GetCppThis(), orbitalNumber, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x060110F8 RID: 69880
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractElectronicData_GetNumberOfElectrons_09(HandleRef pThis);

		/// <summary>
		/// Returns the number of electrons in the molecule.
		/// </summary>
		// Token: 0x060110F9 RID: 69881 RVA: 0x0017C690 File Offset: 0x0017A890
		public virtual long GetNumberOfElectrons()
		{
			return vtkAbstractElectronicData.vtkAbstractElectronicData_GetNumberOfElectrons_09(base.GetCppThis());
		}

		// Token: 0x060110FA RID: 69882
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractElectronicData_GetNumberOfGenerationsFromBase_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060110FB RID: 69883 RVA: 0x0017C6B0 File Offset: 0x0017A8B0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkAbstractElectronicData.vtkAbstractElectronicData_GetNumberOfGenerationsFromBase_10(base.GetCppThis(), type);
		}

		// Token: 0x060110FC RID: 69884
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractElectronicData_GetNumberOfGenerationsFromBaseType_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060110FD RID: 69885 RVA: 0x0017C6D0 File Offset: 0x0017A8D0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkAbstractElectronicData.vtkAbstractElectronicData_GetNumberOfGenerationsFromBaseType_11(type);
		}

		// Token: 0x060110FE RID: 69886
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkAbstractElectronicData_GetNumberOfMOs_12(HandleRef pThis);

		/// <summary>
		/// Returns the number of molecular orbitals available.
		/// </summary>
		// Token: 0x060110FF RID: 69887 RVA: 0x0017C6EC File Offset: 0x0017A8EC
		public virtual long GetNumberOfMOs()
		{
			return vtkAbstractElectronicData.vtkAbstractElectronicData_GetNumberOfMOs_12(base.GetCppThis());
		}

		// Token: 0x06011100 RID: 69888
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkAbstractElectronicData_GetPadding_13(HandleRef pThis);

		/// <summary>
		/// Get the padding between the molecule and the cube boundaries. This is
		/// used to determine the dataset's bounds.
		/// </summary>
		// Token: 0x06011101 RID: 69889 RVA: 0x0017C70C File Offset: 0x0017A90C
		public virtual double GetPadding()
		{
			return vtkAbstractElectronicData.vtkAbstractElectronicData_GetPadding_13(base.GetCppThis());
		}

		// Token: 0x06011102 RID: 69890
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractElectronicData_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011103 RID: 69891 RVA: 0x0017C72C File Offset: 0x0017A92C
		public override int IsA(string type)
		{
			return vtkAbstractElectronicData.vtkAbstractElectronicData_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x06011104 RID: 69892
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAbstractElectronicData_IsHOMO_15(HandleRef pThis, long orbitalNumber);

		/// <summary>
		/// Returns true if the given orbital number is the Highest Occupied
		/// Molecular Orbital, false otherwise.
		/// </summary>
		// Token: 0x06011105 RID: 69893 RVA: 0x0017C74C File Offset: 0x0017A94C
		public bool IsHOMO(long orbitalNumber)
		{
			return vtkAbstractElectronicData.vtkAbstractElectronicData_IsHOMO_15(base.GetCppThis(), orbitalNumber) != 0;
		}

		// Token: 0x06011106 RID: 69894
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkAbstractElectronicData_IsLUMO_16(HandleRef pThis, long orbitalNumber);

		/// <summary>
		/// Returns true if the given orbital number is the Lowest Unoccupied
		/// Molecular Orbital, false otherwise.
		/// </summary>
		// Token: 0x06011107 RID: 69895 RVA: 0x0017C774 File Offset: 0x0017A974
		public bool IsLUMO(long orbitalNumber)
		{
			return vtkAbstractElectronicData.vtkAbstractElectronicData_IsLUMO_16(base.GetCppThis(), orbitalNumber) != 0;
		}

		// Token: 0x06011108 RID: 69896
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkAbstractElectronicData_IsTypeOf_17([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06011109 RID: 69897 RVA: 0x0017C79C File Offset: 0x0017A99C
		public new static int IsTypeOf(string type)
		{
			return vtkAbstractElectronicData.vtkAbstractElectronicData_IsTypeOf_17(type);
		}

		// Token: 0x0601110A RID: 69898
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractElectronicData_NewInstance_18(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601110B RID: 69899 RVA: 0x0017C7B8 File Offset: 0x0017A9B8
		public new vtkAbstractElectronicData NewInstance()
		{
			vtkAbstractElectronicData result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractElectronicData.vtkAbstractElectronicData_NewInstance_18(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkAbstractElectronicData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601110C RID: 69900
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkAbstractElectronicData_SafeDownCast_19(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601110D RID: 69901 RVA: 0x0017C814 File Offset: 0x0017AA14
		public new static vtkAbstractElectronicData SafeDownCast(vtkObjectBase o)
		{
			vtkAbstractElectronicData vtkAbstractElectronicData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkAbstractElectronicData.vtkAbstractElectronicData_SafeDownCast_19((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractElectronicData = (vtkAbstractElectronicData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractElectronicData.Register(null);
				}
			}
			return vtkAbstractElectronicData;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013B4 RID: 5044
		public new const string MRFullTypeName = "Kitware.VTK.vtkAbstractElectronicData";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040013B5 RID: 5045
		public new static readonly string MRClassNameKey = "class vtkAbstractElectronicData";
	}
}
