using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkDateToNumeric
	/// </summary>
	/// <remarks>
	///    Converts string dates to numeric values
	///
	///
	/// This filter preserves all the topology of the input. All string arrays are
	/// examined to see if their value is a date. If so an array is added with the
	/// numeric value of that date. The new array is of type double and its name
	/// is the source arrays name with _numeric appended.
	///
	/// default date formats parsed include
	///
	///   "%Y-%m-%d %H:%M:%S"
	///   "%d/%m/%Y %H:%M:%S"
	/// </remarks>
	// Token: 0x0200088F RID: 2191
	public class vtkDateToNumeric : vtkPassInputTypeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016C0E RID: 93198 RVA: 0x001FFE8D File Offset: 0x001FE08D
		static vtkDateToNumeric()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkDateToNumeric.MRClassNameKey, Type.GetType("Kitware.VTK.vtkDateToNumeric"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016C0F RID: 93199 RVA: 0x001FFEB5 File Offset: 0x001FE0B5
		public vtkDateToNumeric(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016C10 RID: 93200
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDateToNumeric_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016C11 RID: 93201 RVA: 0x001FFEC4 File Offset: 0x001FE0C4
		public new static vtkDateToNumeric New()
		{
			vtkDateToNumeric result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDateToNumeric.vtkDateToNumeric_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDateToNumeric)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016C12 RID: 93202 RVA: 0x001FFF18 File Offset: 0x001FE118
		public vtkDateToNumeric() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkDateToNumeric.vtkDateToNumeric_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016C13 RID: 93203 RVA: 0x001FFF5C File Offset: 0x001FE15C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016C14 RID: 93204
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDateToNumeric_GetDateFormat_01(HandleRef pThis);

		/// <summary>
		/// You can specify your own format to parse dates by. This string
		/// follows the formatting conventions of std::get_time
		/// </summary>
		// Token: 0x06016C15 RID: 93205 RVA: 0x001FFF68 File Offset: 0x001FE168
		public virtual string GetDateFormat()
		{
			string s = Marshal.PtrToStringAnsi(vtkDateToNumeric.vtkDateToNumeric_GetDateFormat_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06016C16 RID: 93206
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDateToNumeric_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016C17 RID: 93207 RVA: 0x001FFFA4 File Offset: 0x001FE1A4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkDateToNumeric.vtkDateToNumeric_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06016C18 RID: 93208
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkDateToNumeric_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016C19 RID: 93209 RVA: 0x001FFFC4 File Offset: 0x001FE1C4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkDateToNumeric.vtkDateToNumeric_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06016C1A RID: 93210
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDateToNumeric_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016C1B RID: 93211 RVA: 0x001FFFE0 File Offset: 0x001FE1E0
		public override int IsA(string type)
		{
			return vtkDateToNumeric.vtkDateToNumeric_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06016C1C RID: 93212
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkDateToNumeric_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016C1D RID: 93213 RVA: 0x00200000 File Offset: 0x001FE200
		public new static int IsTypeOf(string type)
		{
			return vtkDateToNumeric.vtkDateToNumeric_IsTypeOf_05(type);
		}

		// Token: 0x06016C1E RID: 93214
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDateToNumeric_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016C1F RID: 93215 RVA: 0x0020001C File Offset: 0x001FE21C
		public new vtkDateToNumeric NewInstance()
		{
			vtkDateToNumeric result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDateToNumeric.vtkDateToNumeric_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkDateToNumeric)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016C20 RID: 93216
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkDateToNumeric_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016C21 RID: 93217 RVA: 0x00200078 File Offset: 0x001FE278
		public new static vtkDateToNumeric SafeDownCast(vtkObjectBase o)
		{
			vtkDateToNumeric vtkDateToNumeric = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkDateToNumeric.vtkDateToNumeric_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDateToNumeric = (vtkDateToNumeric)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDateToNumeric.Register(null);
				}
			}
			return vtkDateToNumeric;
		}

		// Token: 0x06016C22 RID: 93218
		[DllImport("Kitware.VTK.FiltersGeneral.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkDateToNumeric_SetDateFormat_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// You can specify your own format to parse dates by. This string
		/// follows the formatting conventions of std::get_time
		/// </summary>
		// Token: 0x06016C23 RID: 93219 RVA: 0x002000F7 File Offset: 0x001FE2F7
		public virtual void SetDateFormat(string _arg)
		{
			vtkDateToNumeric.vtkDateToNumeric_SetDateFormat_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400197F RID: 6527
		public new const string MRFullTypeName = "Kitware.VTK.vtkDateToNumeric";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001980 RID: 6528
		public new static readonly string MRClassNameKey = "class vtkDateToNumeric";
	}
}
