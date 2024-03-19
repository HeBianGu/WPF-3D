using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXMLMultiGroupDataReader
	/// </summary>
	/// <remarks>
	///    Reader for multi-block datasets
	///
	/// vtkXMLMultiGroupDataReader is a legacy reader that reads multi group files
	/// into multiblock datasets.
	/// </remarks>
	// Token: 0x020006CD RID: 1741
	public class vtkXMLMultiGroupDataReader : vtkXMLMultiBlockDataReader
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012815 RID: 75797 RVA: 0x0019F28F File Offset: 0x0019D48F
		static vtkXMLMultiGroupDataReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXMLMultiGroupDataReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXMLMultiGroupDataReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012816 RID: 75798 RVA: 0x0019F2B7 File Offset: 0x0019D4B7
		public vtkXMLMultiGroupDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012817 RID: 75799
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLMultiGroupDataReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012818 RID: 75800 RVA: 0x0019F2C8 File Offset: 0x0019D4C8
		public new static vtkXMLMultiGroupDataReader New()
		{
			vtkXMLMultiGroupDataReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLMultiGroupDataReader.vtkXMLMultiGroupDataReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLMultiGroupDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012819 RID: 75801 RVA: 0x0019F31C File Offset: 0x0019D51C
		public vtkXMLMultiGroupDataReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXMLMultiGroupDataReader.vtkXMLMultiGroupDataReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601281A RID: 75802 RVA: 0x0019F360 File Offset: 0x0019D560
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601281B RID: 75803
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLMultiGroupDataReader_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601281C RID: 75804 RVA: 0x0019F36C File Offset: 0x0019D56C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXMLMultiGroupDataReader.vtkXMLMultiGroupDataReader_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601281D RID: 75805
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXMLMultiGroupDataReader_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601281E RID: 75806 RVA: 0x0019F38C File Offset: 0x0019D58C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXMLMultiGroupDataReader.vtkXMLMultiGroupDataReader_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601281F RID: 75807
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLMultiGroupDataReader_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012820 RID: 75808 RVA: 0x0019F3A8 File Offset: 0x0019D5A8
		public override int IsA(string type)
		{
			return vtkXMLMultiGroupDataReader.vtkXMLMultiGroupDataReader_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06012821 RID: 75809
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXMLMultiGroupDataReader_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012822 RID: 75810 RVA: 0x0019F3C8 File Offset: 0x0019D5C8
		public new static int IsTypeOf(string type)
		{
			return vtkXMLMultiGroupDataReader.vtkXMLMultiGroupDataReader_IsTypeOf_04(type);
		}

		// Token: 0x06012823 RID: 75811
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLMultiGroupDataReader_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012824 RID: 75812 RVA: 0x0019F3E4 File Offset: 0x0019D5E4
		public new vtkXMLMultiGroupDataReader NewInstance()
		{
			vtkXMLMultiGroupDataReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLMultiGroupDataReader.vtkXMLMultiGroupDataReader_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXMLMultiGroupDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012825 RID: 75813
		[DllImport("Kitware.VTK.IOXML.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXMLMultiGroupDataReader_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012826 RID: 75814 RVA: 0x0019F440 File Offset: 0x0019D640
		public new static vtkXMLMultiGroupDataReader SafeDownCast(vtkObjectBase o)
		{
			vtkXMLMultiGroupDataReader vtkXMLMultiGroupDataReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXMLMultiGroupDataReader.vtkXMLMultiGroupDataReader_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXMLMultiGroupDataReader = (vtkXMLMultiGroupDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXMLMultiGroupDataReader.Register(null);
				}
			}
			return vtkXMLMultiGroupDataReader;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400154B RID: 5451
		public new const string MRFullTypeName = "Kitware.VTK.vtkXMLMultiGroupDataReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400154C RID: 5452
		public new static readonly string MRClassNameKey = "class vtkXMLMultiGroupDataReader";
	}
}
