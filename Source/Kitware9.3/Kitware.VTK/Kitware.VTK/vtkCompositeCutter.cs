using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCompositeCutter
	/// </summary>
	/// <remarks>
	///    Cut composite data sets with user-specified implicit function
	///
	/// Loop over each data set in the composite input and apply vtkCutter
	/// </remarks>
	/// <seealso>
	///
	/// vtkCutter
	/// </seealso>
	// Token: 0x0200094B RID: 2379
	public class vtkCompositeCutter : vtkCutter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06018ABC RID: 101052 RVA: 0x0022778A File Offset: 0x0022598A
		static vtkCompositeCutter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCompositeCutter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCompositeCutter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06018ABD RID: 101053 RVA: 0x002277B2 File Offset: 0x002259B2
		public vtkCompositeCutter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06018ABE RID: 101054
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeCutter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018ABF RID: 101055 RVA: 0x002277C0 File Offset: 0x002259C0
		public new static vtkCompositeCutter New()
		{
			vtkCompositeCutter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeCutter.vtkCompositeCutter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeCutter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018AC0 RID: 101056 RVA: 0x00227814 File Offset: 0x00225A14
		public vtkCompositeCutter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCompositeCutter.vtkCompositeCutter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06018AC1 RID: 101057 RVA: 0x00227858 File Offset: 0x00225A58
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06018AC2 RID: 101058
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeCutter_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018AC3 RID: 101059 RVA: 0x00227864 File Offset: 0x00225A64
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCompositeCutter.vtkCompositeCutter_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06018AC4 RID: 101060
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCompositeCutter_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018AC5 RID: 101061 RVA: 0x00227884 File Offset: 0x00225A84
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCompositeCutter.vtkCompositeCutter_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06018AC6 RID: 101062
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeCutter_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018AC7 RID: 101063 RVA: 0x002278A0 File Offset: 0x00225AA0
		public override int IsA(string type)
		{
			return vtkCompositeCutter.vtkCompositeCutter_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06018AC8 RID: 101064
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCompositeCutter_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018AC9 RID: 101065 RVA: 0x002278C0 File Offset: 0x00225AC0
		public new static int IsTypeOf(string type)
		{
			return vtkCompositeCutter.vtkCompositeCutter_IsTypeOf_04(type);
		}

		// Token: 0x06018ACA RID: 101066
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeCutter_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018ACB RID: 101067 RVA: 0x002278DC File Offset: 0x00225ADC
		public new vtkCompositeCutter NewInstance()
		{
			vtkCompositeCutter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeCutter.vtkCompositeCutter_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCompositeCutter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06018ACC RID: 101068
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCompositeCutter_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06018ACD RID: 101069 RVA: 0x00227938 File Offset: 0x00225B38
		public new static vtkCompositeCutter SafeDownCast(vtkObjectBase o)
		{
			vtkCompositeCutter vtkCompositeCutter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCompositeCutter.vtkCompositeCutter_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCompositeCutter = (vtkCompositeCutter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCompositeCutter.Register(null);
				}
			}
			return vtkCompositeCutter;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B4A RID: 6986
		public new const string MRFullTypeName = "Kitware.VTK.vtkCompositeCutter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B4B RID: 6987
		public new static readonly string MRClassNameKey = "class vtkCompositeCutter";
	}
}
