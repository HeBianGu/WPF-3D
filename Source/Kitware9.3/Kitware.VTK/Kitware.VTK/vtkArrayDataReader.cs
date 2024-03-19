using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkArrayDataReader
	/// </summary>
	/// <remarks>
	///     Reads vtkArrayData written by vtkArrayDataWriter.
	///
	///
	/// Reads vtkArrayData data written with vtkArrayDataWriter.
	///
	/// Outputs:
	///   Output port 0: vtkArrayData containing a collection of vtkArrays.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkArrayDataWriter
	/// </seealso>
	// Token: 0x0200071C RID: 1820
	public class vtkArrayDataReader : vtkArrayDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060130D3 RID: 78035 RVA: 0x001AEBC5 File Offset: 0x001ACDC5
		static vtkArrayDataReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkArrayDataReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkArrayDataReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060130D4 RID: 78036 RVA: 0x001AEBED File Offset: 0x001ACDED
		public vtkArrayDataReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060130D5 RID: 78037
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayDataReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060130D6 RID: 78038 RVA: 0x001AEBFC File Offset: 0x001ACDFC
		public new static vtkArrayDataReader New()
		{
			vtkArrayDataReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayDataReader.vtkArrayDataReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrayDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060130D7 RID: 78039 RVA: 0x001AEC50 File Offset: 0x001ACE50
		public vtkArrayDataReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkArrayDataReader.vtkArrayDataReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060130D8 RID: 78040 RVA: 0x001AEC94 File Offset: 0x001ACE94
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060130D9 RID: 78041
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayDataReader_GetFileName_01(HandleRef pThis);

		/// <summary>
		/// Set the filesystem location from which data will be read.
		/// </summary>
		// Token: 0x060130DA RID: 78042 RVA: 0x001AECA0 File Offset: 0x001ACEA0
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkArrayDataReader.vtkArrayDataReader_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060130DB RID: 78043
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		[return: MarshalAs(UnmanagedType.LPUTF8Str)]
		internal static extern string vtkArrayDataReader_GetInputString_02(HandleRef pThis);

		/// <summary>
		/// The input string to parse. If you set the input string, you must also set
		/// the ReadFromInputString flag to parse the string instead of a file.
		/// </summary>
		// Token: 0x060130DC RID: 78044 RVA: 0x001AECDC File Offset: 0x001ACEDC
		public virtual string GetInputString()
		{
			return vtkArrayDataReader.vtkArrayDataReader_GetInputString_02(base.GetCppThis());
		}

		// Token: 0x060130DD RID: 78045
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArrayDataReader_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060130DE RID: 78046 RVA: 0x001AECFC File Offset: 0x001ACEFC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkArrayDataReader.vtkArrayDataReader_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x060130DF RID: 78047
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkArrayDataReader_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060130E0 RID: 78048 RVA: 0x001AED1C File Offset: 0x001ACF1C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkArrayDataReader.vtkArrayDataReader_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x060130E1 RID: 78049
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkArrayDataReader_GetReadFromInputString_05(HandleRef pThis);

		/// <summary>
		/// Whether to read from an input string as opposed to a file, which is the default.
		/// </summary>
		// Token: 0x060130E2 RID: 78050 RVA: 0x001AED38 File Offset: 0x001ACF38
		public virtual bool GetReadFromInputString()
		{
			return vtkArrayDataReader.vtkArrayDataReader_GetReadFromInputString_05(base.GetCppThis()) != 0;
		}

		// Token: 0x060130E3 RID: 78051
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayDataReader_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060130E4 RID: 78052 RVA: 0x001AED60 File Offset: 0x001ACF60
		public override int IsA(string type)
		{
			return vtkArrayDataReader.vtkArrayDataReader_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x060130E5 RID: 78053
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkArrayDataReader_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060130E6 RID: 78054 RVA: 0x001AED80 File Offset: 0x001ACF80
		public new static int IsTypeOf(string type)
		{
			return vtkArrayDataReader.vtkArrayDataReader_IsTypeOf_07(type);
		}

		// Token: 0x060130E7 RID: 78055
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayDataReader_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060130E8 RID: 78056 RVA: 0x001AED9C File Offset: 0x001ACF9C
		public new vtkArrayDataReader NewInstance()
		{
			vtkArrayDataReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayDataReader.vtkArrayDataReader_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkArrayDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060130E9 RID: 78057
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayDataReader_Read_10([MarshalAs(UnmanagedType.LPUTF8Str)] string str, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Read an arbitrary array from a string.
		/// </summary>
		// Token: 0x060130EA RID: 78058 RVA: 0x001AEDF8 File Offset: 0x001ACFF8
		public static vtkArrayData Read(string str)
		{
			vtkArrayData vtkArrayData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayDataReader.vtkArrayDataReader_Read_10(str, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArrayData = (vtkArrayData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArrayData.Register(null);
				}
			}
			return vtkArrayData;
		}

		// Token: 0x060130EB RID: 78059
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayDataReader_ReadFromInputStringOff_11(HandleRef pThis);

		/// <summary>
		/// Whether to read from an input string as opposed to a file, which is the default.
		/// </summary>
		// Token: 0x060130EC RID: 78060 RVA: 0x001AEE62 File Offset: 0x001AD062
		public virtual void ReadFromInputStringOff()
		{
			vtkArrayDataReader.vtkArrayDataReader_ReadFromInputStringOff_11(base.GetCppThis());
		}

		// Token: 0x060130ED RID: 78061
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayDataReader_ReadFromInputStringOn_12(HandleRef pThis);

		/// <summary>
		/// Whether to read from an input string as opposed to a file, which is the default.
		/// </summary>
		// Token: 0x060130EE RID: 78062 RVA: 0x001AEE71 File Offset: 0x001AD071
		public virtual void ReadFromInputStringOn()
		{
			vtkArrayDataReader.vtkArrayDataReader_ReadFromInputStringOn_12(base.GetCppThis());
		}

		// Token: 0x060130EF RID: 78063
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkArrayDataReader_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060130F0 RID: 78064 RVA: 0x001AEE80 File Offset: 0x001AD080
		public new static vtkArrayDataReader SafeDownCast(vtkObjectBase o)
		{
			vtkArrayDataReader vtkArrayDataReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkArrayDataReader.vtkArrayDataReader_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkArrayDataReader = (vtkArrayDataReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkArrayDataReader.Register(null);
				}
			}
			return vtkArrayDataReader;
		}

		// Token: 0x060130F1 RID: 78065
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayDataReader_SetFileName_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Set the filesystem location from which data will be read.
		/// </summary>
		// Token: 0x060130F2 RID: 78066 RVA: 0x001AEEFF File Offset: 0x001AD0FF
		public virtual void SetFileName(string _arg)
		{
			vtkArrayDataReader.vtkArrayDataReader_SetFileName_14(base.GetCppThis(), _arg);
		}

		// Token: 0x060130F3 RID: 78067
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayDataReader_SetInputString_15(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg0);

		/// <summary>
		/// The input string to parse. If you set the input string, you must also set
		/// the ReadFromInputString flag to parse the string instead of a file.
		/// </summary>
		// Token: 0x060130F4 RID: 78068 RVA: 0x001AEF0F File Offset: 0x001AD10F
		public virtual void SetInputString(string arg0)
		{
			vtkArrayDataReader.vtkArrayDataReader_SetInputString_15(base.GetCppThis(), arg0);
		}

		// Token: 0x060130F5 RID: 78069
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkArrayDataReader_SetReadFromInputString_16(HandleRef pThis, byte _arg);

		/// <summary>
		/// Whether to read from an input string as opposed to a file, which is the default.
		/// </summary>
		// Token: 0x060130F6 RID: 78070 RVA: 0x001AEF1F File Offset: 0x001AD11F
		public virtual void SetReadFromInputString(bool _arg)
		{
			vtkArrayDataReader.vtkArrayDataReader_SetReadFromInputString_16(base.GetCppThis(), _arg ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001604 RID: 5636
		public new const string MRFullTypeName = "Kitware.VTK.vtkArrayDataReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001605 RID: 5637
		public new static readonly string MRClassNameKey = "class vtkArrayDataReader";
	}
}
