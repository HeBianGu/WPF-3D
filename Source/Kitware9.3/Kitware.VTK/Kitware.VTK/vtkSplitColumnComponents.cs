using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSplitColumnComponents
	/// </summary>
	/// <remarks>
	///    split multicomponent table columns
	///
	///
	/// Splits any columns in a table that have more than one component into
	/// individual columns. Single component columns are passed through without
	/// any data duplication.
	/// NamingMode can be used to control how columns with multiple components are
	/// labelled in the output, e.g., if column names "Points" had three components
	/// this column would be split into "Points (0)", "Points (1)", and Points (2)"
	/// when NamingMode is NUMBERS_WITH_PARENS, into Points_0, Points_1, and Points_2
	/// when NamingMode is NUMBERS_WITH_UNDERSCORES, into "Points (X)", "Points (Y)",
	/// and "Points (Z)" when NamingMode is NAMES_WITH_PARENS, and into Points_X,
	/// Points_Y, and Points_Z when NamingMode is NAMES_WITH_UNDERSCORES.
	/// </remarks>
	// Token: 0x020008E3 RID: 2275
	public class vtkSplitColumnComponents : vtkTableAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06017807 RID: 96263 RVA: 0x0020F9A7 File Offset: 0x0020DBA7
		static vtkSplitColumnComponents()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSplitColumnComponents.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSplitColumnComponents"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06017808 RID: 96264 RVA: 0x0020F9CF File Offset: 0x0020DBCF
		public vtkSplitColumnComponents(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06017809 RID: 96265
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplitColumnComponents_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601780A RID: 96266 RVA: 0x0020F9E0 File Offset: 0x0020DBE0
		public new static vtkSplitColumnComponents New()
		{
			vtkSplitColumnComponents result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSplitColumnComponents.vtkSplitColumnComponents_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSplitColumnComponents)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601780B RID: 96267 RVA: 0x0020FA34 File Offset: 0x0020DC34
		public vtkSplitColumnComponents() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSplitColumnComponents.vtkSplitColumnComponents_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601780C RID: 96268 RVA: 0x0020FA78 File Offset: 0x0020DC78
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601780D RID: 96269
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplitColumnComponents_CalculateMagnitudesOff_01(HandleRef pThis);

		/// <summary>
		/// If on this filter will calculate an additional magnitude column for all
		/// columns it splits with two or more components.
		/// Default is on.
		/// </summary>
		// Token: 0x0601780E RID: 96270 RVA: 0x0020FA83 File Offset: 0x0020DC83
		public virtual void CalculateMagnitudesOff()
		{
			vtkSplitColumnComponents.vtkSplitColumnComponents_CalculateMagnitudesOff_01(base.GetCppThis());
		}

		// Token: 0x0601780F RID: 96271
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplitColumnComponents_CalculateMagnitudesOn_02(HandleRef pThis);

		/// <summary>
		/// If on this filter will calculate an additional magnitude column for all
		/// columns it splits with two or more components.
		/// Default is on.
		/// </summary>
		// Token: 0x06017810 RID: 96272 RVA: 0x0020FA92 File Offset: 0x0020DC92
		public virtual void CalculateMagnitudesOn()
		{
			vtkSplitColumnComponents.vtkSplitColumnComponents_CalculateMagnitudesOn_02(base.GetCppThis());
		}

		// Token: 0x06017811 RID: 96273
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkSplitColumnComponents_GetCalculateMagnitudes_03(HandleRef pThis);

		/// <summary>
		/// If on this filter will calculate an additional magnitude column for all
		/// columns it splits with two or more components.
		/// Default is on.
		/// </summary>
		// Token: 0x06017812 RID: 96274 RVA: 0x0020FAA4 File Offset: 0x0020DCA4
		public virtual bool GetCalculateMagnitudes()
		{
			return vtkSplitColumnComponents.vtkSplitColumnComponents_GetCalculateMagnitudes_03(base.GetCppThis()) != 0;
		}

		// Token: 0x06017813 RID: 96275
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplitColumnComponents_GetNamingMode_04(HandleRef pThis);

		/// <summary>
		/// Get/Set the array naming mode.
		/// Description is NUMBERS_WITH_PARENS.
		/// </summary>
		// Token: 0x06017814 RID: 96276 RVA: 0x0020FACC File Offset: 0x0020DCCC
		public virtual int GetNamingMode()
		{
			return vtkSplitColumnComponents.vtkSplitColumnComponents_GetNamingMode_04(base.GetCppThis());
		}

		// Token: 0x06017815 RID: 96277
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplitColumnComponents_GetNamingModeMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Get/Set the array naming mode.
		/// Description is NUMBERS_WITH_PARENS.
		/// </summary>
		// Token: 0x06017816 RID: 96278 RVA: 0x0020FAEC File Offset: 0x0020DCEC
		public virtual int GetNamingModeMaxValue()
		{
			return vtkSplitColumnComponents.vtkSplitColumnComponents_GetNamingModeMaxValue_05(base.GetCppThis());
		}

		// Token: 0x06017817 RID: 96279
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplitColumnComponents_GetNamingModeMinValue_06(HandleRef pThis);

		/// <summary>
		/// Get/Set the array naming mode.
		/// Description is NUMBERS_WITH_PARENS.
		/// </summary>
		// Token: 0x06017818 RID: 96280 RVA: 0x0020FB0C File Offset: 0x0020DD0C
		public virtual int GetNamingModeMinValue()
		{
			return vtkSplitColumnComponents.vtkSplitColumnComponents_GetNamingModeMinValue_06(base.GetCppThis());
		}

		// Token: 0x06017819 RID: 96281
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSplitColumnComponents_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601781A RID: 96282 RVA: 0x0020FB2C File Offset: 0x0020DD2C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSplitColumnComponents.vtkSplitColumnComponents_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x0601781B RID: 96283
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSplitColumnComponents_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601781C RID: 96284 RVA: 0x0020FB4C File Offset: 0x0020DD4C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSplitColumnComponents.vtkSplitColumnComponents_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x0601781D RID: 96285
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplitColumnComponents_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601781E RID: 96286 RVA: 0x0020FB68 File Offset: 0x0020DD68
		public override int IsA(string type)
		{
			return vtkSplitColumnComponents.vtkSplitColumnComponents_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0601781F RID: 96287
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSplitColumnComponents_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017820 RID: 96288 RVA: 0x0020FB88 File Offset: 0x0020DD88
		public new static int IsTypeOf(string type)
		{
			return vtkSplitColumnComponents.vtkSplitColumnComponents_IsTypeOf_10(type);
		}

		// Token: 0x06017821 RID: 96289
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplitColumnComponents_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017822 RID: 96290 RVA: 0x0020FBA4 File Offset: 0x0020DDA4
		public new vtkSplitColumnComponents NewInstance()
		{
			vtkSplitColumnComponents result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSplitColumnComponents.vtkSplitColumnComponents_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSplitColumnComponents)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06017823 RID: 96291
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplitColumnComponents_ORIGINAL_ARRAY_NAME_13(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// These are keys that get added to each output array to make it easier for
		/// downstream filters to know which output array were extracted from which
		/// input array.
		///
		/// If either of these keys are missing, then the array was not extracted at
		/// all.
		///
		/// `ORIGINAL_COMPONENT_NUMBER` of -1 indicates magnitude.
		/// </summary>
		// Token: 0x06017824 RID: 96292 RVA: 0x0020FC00 File Offset: 0x0020DE00
		public static vtkInformationStringKey ORIGINAL_ARRAY_NAME()
		{
			vtkInformationStringKey vtkInformationStringKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSplitColumnComponents.vtkSplitColumnComponents_ORIGINAL_ARRAY_NAME_13(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationStringKey = (vtkInformationStringKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationStringKey.Register(null);
				}
			}
			return vtkInformationStringKey;
		}

		// Token: 0x06017825 RID: 96293
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplitColumnComponents_ORIGINAL_COMPONENT_NUMBER_14(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// These are keys that get added to each output array to make it easier for
		/// downstream filters to know which output array were extracted from which
		/// input array.
		///
		/// If either of these keys are missing, then the array was not extracted at
		/// all.
		///
		/// `ORIGINAL_COMPONENT_NUMBER` of -1 indicates magnitude.
		/// </summary>
		// Token: 0x06017826 RID: 96294 RVA: 0x0020FC6C File Offset: 0x0020DE6C
		public static vtkInformationIntegerKey ORIGINAL_COMPONENT_NUMBER()
		{
			vtkInformationIntegerKey vtkInformationIntegerKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSplitColumnComponents.vtkSplitColumnComponents_ORIGINAL_COMPONENT_NUMBER_14(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationIntegerKey = (vtkInformationIntegerKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationIntegerKey.Register(null);
				}
			}
			return vtkInformationIntegerKey;
		}

		// Token: 0x06017827 RID: 96295
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSplitColumnComponents_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06017828 RID: 96296 RVA: 0x0020FCD8 File Offset: 0x0020DED8
		public new static vtkSplitColumnComponents SafeDownCast(vtkObjectBase o)
		{
			vtkSplitColumnComponents vtkSplitColumnComponents = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSplitColumnComponents.vtkSplitColumnComponents_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSplitColumnComponents = (vtkSplitColumnComponents)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSplitColumnComponents.Register(null);
				}
			}
			return vtkSplitColumnComponents;
		}

		// Token: 0x06017829 RID: 96297
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplitColumnComponents_SetCalculateMagnitudes_16(HandleRef pThis, byte _arg);

		/// <summary>
		/// If on this filter will calculate an additional magnitude column for all
		/// columns it splits with two or more components.
		/// Default is on.
		/// </summary>
		// Token: 0x0601782A RID: 96298 RVA: 0x0020FD57 File Offset: 0x0020DF57
		public virtual void SetCalculateMagnitudes(bool _arg)
		{
			vtkSplitColumnComponents.vtkSplitColumnComponents_SetCalculateMagnitudes_16(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		// Token: 0x0601782B RID: 96299
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplitColumnComponents_SetNamingMode_17(HandleRef pThis, int _arg);

		/// <summary>
		/// Get/Set the array naming mode.
		/// Description is NUMBERS_WITH_PARENS.
		/// </summary>
		// Token: 0x0601782C RID: 96300 RVA: 0x0020FD6F File Offset: 0x0020DF6F
		public virtual void SetNamingMode(int _arg)
		{
			vtkSplitColumnComponents.vtkSplitColumnComponents_SetNamingMode_17(base.GetCppThis(), _arg);
		}

		// Token: 0x0601782D RID: 96301
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplitColumnComponents_SetNamingModeToNamesWithParens_18(HandleRef pThis);

		/// <summary>
		/// Get/Set the array naming mode.
		/// Description is NUMBERS_WITH_PARENS.
		/// </summary>
		// Token: 0x0601782E RID: 96302 RVA: 0x0020FD7F File Offset: 0x0020DF7F
		public void SetNamingModeToNamesWithParens()
		{
			vtkSplitColumnComponents.vtkSplitColumnComponents_SetNamingModeToNamesWithParens_18(base.GetCppThis());
		}

		// Token: 0x0601782F RID: 96303
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplitColumnComponents_SetNamingModeToNamesWithUnderscores_19(HandleRef pThis);

		/// <summary>
		/// Get/Set the array naming mode.
		/// Description is NUMBERS_WITH_PARENS.
		/// </summary>
		// Token: 0x06017830 RID: 96304 RVA: 0x0020FD8E File Offset: 0x0020DF8E
		public void SetNamingModeToNamesWithUnderscores()
		{
			vtkSplitColumnComponents.vtkSplitColumnComponents_SetNamingModeToNamesWithUnderscores_19(base.GetCppThis());
		}

		// Token: 0x06017831 RID: 96305
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplitColumnComponents_SetNamingModeToNumberWithParens_20(HandleRef pThis);

		/// <summary>
		/// Get/Set the array naming mode.
		/// Description is NUMBERS_WITH_PARENS.
		/// </summary>
		// Token: 0x06017832 RID: 96306 RVA: 0x0020FD9D File Offset: 0x0020DF9D
		public void SetNamingModeToNumberWithParens()
		{
			vtkSplitColumnComponents.vtkSplitColumnComponents_SetNamingModeToNumberWithParens_20(base.GetCppThis());
		}

		// Token: 0x06017833 RID: 96307
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSplitColumnComponents_SetNamingModeToNumberWithUnderscores_21(HandleRef pThis);

		/// <summary>
		/// Get/Set the array naming mode.
		/// Description is NUMBERS_WITH_PARENS.
		/// </summary>
		// Token: 0x06017834 RID: 96308 RVA: 0x0020FDAC File Offset: 0x0020DFAC
		public void SetNamingModeToNumberWithUnderscores()
		{
			vtkSplitColumnComponents.vtkSplitColumnComponents_SetNamingModeToNumberWithUnderscores_21(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A3B RID: 6715
		public new const string MRFullTypeName = "Kitware.VTK.vtkSplitColumnComponents";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001A3C RID: 6716
		public new static readonly string MRClassNameKey = "class vtkSplitColumnComponents";

		/// <summary>
		/// If on this filter will calculate an additional magnitude column for all
		/// columns it splits with two or more components.
		/// Default is on.
		/// </summary>
		// Token: 0x020008E4 RID: 2276
		public enum NAMES_WITH_PARENS_WrapperEnum
		{
			/// <summary>enum member</summary>
			// Token: 0x04001A3E RID: 6718
			NAMES_WITH_PARENS = 1,
			/// <summary>enum member</summary>
			// Token: 0x04001A3F RID: 6719
			NAMES_WITH_UNDERSCORES = 3,
			/// <summary>enum member</summary>
			// Token: 0x04001A40 RID: 6720
			NUMBERS_WITH_PARENS = 0,
			/// <summary>enum member</summary>
			// Token: 0x04001A41 RID: 6721
			NUMBERS_WITH_UNDERSCORES = 2
		}
	}
}
