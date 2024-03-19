using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInformationKeyLookup
	/// </summary>
	/// <remarks>
	///    Find vtkInformationKeys from name and
	/// location strings.
	/// </remarks>
	// Token: 0x02000B61 RID: 2913
	public class vtkInformationKeyLookup : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E747 RID: 124743 RVA: 0x002B2B9B File Offset: 0x002B0D9B
		static vtkInformationKeyLookup()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformationKeyLookup.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformationKeyLookup"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E748 RID: 124744 RVA: 0x002B2BC3 File Offset: 0x002B0DC3
		public vtkInformationKeyLookup(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E749 RID: 124745
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationKeyLookup_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E74A RID: 124746 RVA: 0x002B2BD4 File Offset: 0x002B0DD4
		public new static vtkInformationKeyLookup New()
		{
			vtkInformationKeyLookup result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationKeyLookup.vtkInformationKeyLookup_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationKeyLookup)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E74B RID: 124747 RVA: 0x002B2C28 File Offset: 0x002B0E28
		public vtkInformationKeyLookup() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkInformationKeyLookup.vtkInformationKeyLookup_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E74C RID: 124748 RVA: 0x002B2C6C File Offset: 0x002B0E6C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E74D RID: 124749
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationKeyLookup_Find_01([MarshalAs(UnmanagedType.LPUTF8Str)] string name, [MarshalAs(UnmanagedType.LPUTF8Str)] string location, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Find an information key from name and location strings. For example,
		/// Find("GUI_HIDE", "vtkAbstractArray") returns vtkAbstractArray::GUI_HIDE.
		/// Note that this class only knows about keys in modules that are currently
		/// linked to the running executable.
		/// </summary>
		// Token: 0x0601E74E RID: 124750 RVA: 0x002B2C78 File Offset: 0x002B0E78
		public static vtkInformationKey Find(string name, string location)
		{
			vtkInformationKey vtkInformationKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationKeyLookup.vtkInformationKeyLookup_Find_01(name, location, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKey = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKey.Register(null);
				}
			}
			return vtkInformationKey;
		}

		// Token: 0x0601E74F RID: 124751
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationKeyLookup_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E750 RID: 124752 RVA: 0x002B2CE4 File Offset: 0x002B0EE4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInformationKeyLookup.vtkInformationKeyLookup_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601E751 RID: 124753
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformationKeyLookup_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E752 RID: 124754 RVA: 0x002B2D04 File Offset: 0x002B0F04
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInformationKeyLookup.vtkInformationKeyLookup_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601E753 RID: 124755
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationKeyLookup_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E754 RID: 124756 RVA: 0x002B2D20 File Offset: 0x002B0F20
		public override int IsA(string type)
		{
			return vtkInformationKeyLookup.vtkInformationKeyLookup_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x0601E755 RID: 124757
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformationKeyLookup_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E756 RID: 124758 RVA: 0x002B2D40 File Offset: 0x002B0F40
		public new static int IsTypeOf(string type)
		{
			return vtkInformationKeyLookup.vtkInformationKeyLookup_IsTypeOf_05(type);
		}

		// Token: 0x0601E757 RID: 124759
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationKeyLookup_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E758 RID: 124760 RVA: 0x002B2D5C File Offset: 0x002B0F5C
		public new vtkInformationKeyLookup NewInstance()
		{
			vtkInformationKeyLookup result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationKeyLookup.vtkInformationKeyLookup_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformationKeyLookup)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E759 RID: 124761
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformationKeyLookup_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E75A RID: 124762 RVA: 0x002B2DB8 File Offset: 0x002B0FB8
		public new static vtkInformationKeyLookup SafeDownCast(vtkObjectBase o)
		{
			vtkInformationKeyLookup vtkInformationKeyLookup = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformationKeyLookup.vtkInformationKeyLookup_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKeyLookup = (vtkInformationKeyLookup)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKeyLookup.Register(null);
				}
			}
			return vtkInformationKeyLookup;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020A1 RID: 8353
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformationKeyLookup";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040020A2 RID: 8354
		public new static readonly string MRClassNameKey = "class vtkInformationKeyLookup";
	}
}
