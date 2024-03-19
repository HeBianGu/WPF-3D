using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkOverrideInformationCollection
	/// </summary>
	/// <remarks>
	///    maintain a list of override information objects
	///
	/// vtkOverrideInformationCollection is an object that creates and manipulates
	/// lists of objects of type vtkOverrideInformation.
	/// </remarks>
	/// <seealso>
	///
	/// vtkCollection
	/// </seealso>
	// Token: 0x02000B78 RID: 2936
	public class vtkOverrideInformationCollection : vtkCollection
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601EA2B RID: 125483 RVA: 0x002B729F File Offset: 0x002B549F
		static vtkOverrideInformationCollection()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkOverrideInformationCollection.MRClassNameKey, Type.GetType("Kitware.VTK.vtkOverrideInformationCollection"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601EA2C RID: 125484 RVA: 0x002B72C7 File Offset: 0x002B54C7
		public vtkOverrideInformationCollection(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601EA2D RID: 125485
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOverrideInformationCollection_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EA2E RID: 125486 RVA: 0x002B72D8 File Offset: 0x002B54D8
		public new static vtkOverrideInformationCollection New()
		{
			vtkOverrideInformationCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOverrideInformationCollection.vtkOverrideInformationCollection_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOverrideInformationCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EA2F RID: 125487 RVA: 0x002B732C File Offset: 0x002B552C
		public vtkOverrideInformationCollection() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkOverrideInformationCollection.vtkOverrideInformationCollection_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601EA30 RID: 125488 RVA: 0x002B7370 File Offset: 0x002B5570
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601EA31 RID: 125489
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkOverrideInformationCollection_AddItem_01(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Add a OverrideInformation to the list.
		/// </summary>
		// Token: 0x0601EA32 RID: 125490 RVA: 0x002B737C File Offset: 0x002B557C
		public void AddItem(vtkOverrideInformation arg0)
		{
			vtkOverrideInformationCollection.vtkOverrideInformationCollection_AddItem_01(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x0601EA33 RID: 125491
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOverrideInformationCollection_GetNextItem_02(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get the next OverrideInformation in the list.
		/// </summary>
		// Token: 0x0601EA34 RID: 125492 RVA: 0x002B73AC File Offset: 0x002B55AC
		public vtkOverrideInformation GetNextItem()
		{
			vtkOverrideInformation vtkOverrideInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOverrideInformationCollection.vtkOverrideInformationCollection_GetNextItem_02(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOverrideInformation = (vtkOverrideInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOverrideInformation.Register(null);
				}
			}
			return vtkOverrideInformation;
		}

		// Token: 0x0601EA35 RID: 125493
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOverrideInformationCollection_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EA36 RID: 125494 RVA: 0x002B741C File Offset: 0x002B561C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkOverrideInformationCollection.vtkOverrideInformationCollection_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x0601EA37 RID: 125495
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkOverrideInformationCollection_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EA38 RID: 125496 RVA: 0x002B743C File Offset: 0x002B563C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkOverrideInformationCollection.vtkOverrideInformationCollection_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x0601EA39 RID: 125497
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOverrideInformationCollection_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EA3A RID: 125498 RVA: 0x002B7458 File Offset: 0x002B5658
		public override int IsA(string type)
		{
			return vtkOverrideInformationCollection.vtkOverrideInformationCollection_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0601EA3B RID: 125499
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkOverrideInformationCollection_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EA3C RID: 125500 RVA: 0x002B7478 File Offset: 0x002B5678
		public new static int IsTypeOf(string type)
		{
			return vtkOverrideInformationCollection.vtkOverrideInformationCollection_IsTypeOf_06(type);
		}

		// Token: 0x0601EA3D RID: 125501
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOverrideInformationCollection_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EA3E RID: 125502 RVA: 0x002B7494 File Offset: 0x002B5694
		public new vtkOverrideInformationCollection NewInstance()
		{
			vtkOverrideInformationCollection result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOverrideInformationCollection.vtkOverrideInformationCollection_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkOverrideInformationCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601EA3F RID: 125503
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkOverrideInformationCollection_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601EA40 RID: 125504 RVA: 0x002B74F0 File Offset: 0x002B56F0
		public new static vtkOverrideInformationCollection SafeDownCast(vtkObjectBase o)
		{
			vtkOverrideInformationCollection vtkOverrideInformationCollection = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkOverrideInformationCollection.vtkOverrideInformationCollection_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkOverrideInformationCollection = (vtkOverrideInformationCollection)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkOverrideInformationCollection.Register(null);
				}
			}
			return vtkOverrideInformationCollection;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020D4 RID: 8404
		public new const string MRFullTypeName = "Kitware.VTK.vtkOverrideInformationCollection";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020D5 RID: 8405
		public new static readonly string MRClassNameKey = "class vtkOverrideInformationCollection";
	}
}
