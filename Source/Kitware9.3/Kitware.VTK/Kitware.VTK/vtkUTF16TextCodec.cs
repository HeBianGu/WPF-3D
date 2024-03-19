using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUTF16TextCodec
	/// </summary>
	/// <remarks>
	///    Class to read/write ascii text.
	///
	///
	/// A virtual class interface for codecs that readers/writers can rely on
	///
	/// @par Thanks:
	/// Thanks to Tim Shed from Sandia National Laboratories for his work
	/// on the concepts and to Marcus Hanwell and Jeff Baumes of Kitware for
	/// keeping me out of the weeds
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkUTF16TextCodecFactory
	///
	/// </seealso>
	// Token: 0x02000737 RID: 1847
	public class vtkUTF16TextCodec : vtkTextCodec
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060133F9 RID: 78841 RVA: 0x001B3823 File Offset: 0x001B1A23
		static vtkUTF16TextCodec()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUTF16TextCodec.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUTF16TextCodec"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060133FA RID: 78842 RVA: 0x001B384B File Offset: 0x001B1A4B
		public vtkUTF16TextCodec(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060133FB RID: 78843
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUTF16TextCodec_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060133FC RID: 78844 RVA: 0x001B385C File Offset: 0x001B1A5C
		public new static vtkUTF16TextCodec New()
		{
			vtkUTF16TextCodec result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUTF16TextCodec.vtkUTF16TextCodec_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUTF16TextCodec)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060133FD RID: 78845 RVA: 0x001B38B0 File Offset: 0x001B1AB0
		public vtkUTF16TextCodec() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkUTF16TextCodec.vtkUTF16TextCodec_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060133FE RID: 78846 RVA: 0x001B38F4 File Offset: 0x001B1AF4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060133FF RID: 78847
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkUTF16TextCodec_CanHandle_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string NameString);

		/// <summary>
		/// The name this codec goes by - should match the string the factory will take to create it
		/// </summary>
		// Token: 0x06013400 RID: 78848 RVA: 0x001B3900 File Offset: 0x001B1B00
		public override bool CanHandle(string NameString)
		{
			return vtkUTF16TextCodec.vtkUTF16TextCodec_CanHandle_01(base.GetCppThis(), NameString) != 0;
		}

		// Token: 0x06013401 RID: 78849
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUTF16TextCodec_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013402 RID: 78850 RVA: 0x001B3928 File Offset: 0x001B1B28
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUTF16TextCodec.vtkUTF16TextCodec_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06013403 RID: 78851
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUTF16TextCodec_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013404 RID: 78852 RVA: 0x001B3948 File Offset: 0x001B1B48
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUTF16TextCodec.vtkUTF16TextCodec_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06013405 RID: 78853
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUTF16TextCodec_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013406 RID: 78854 RVA: 0x001B3964 File Offset: 0x001B1B64
		public override int IsA(string type)
		{
			return vtkUTF16TextCodec.vtkUTF16TextCodec_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06013407 RID: 78855
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUTF16TextCodec_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013408 RID: 78856 RVA: 0x001B3984 File Offset: 0x001B1B84
		public new static int IsTypeOf(string type)
		{
			return vtkUTF16TextCodec.vtkUTF16TextCodec_IsTypeOf_05(type);
		}

		// Token: 0x06013409 RID: 78857
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUTF16TextCodec_Name_06(HandleRef pThis);

		/// <summary>
		/// The name this codec goes by - should match the string the factory will take to create it
		/// </summary>
		// Token: 0x0601340A RID: 78858 RVA: 0x001B39A0 File Offset: 0x001B1BA0
		public override string Name()
		{
			string s = Marshal.PtrToStringAnsi(vtkUTF16TextCodec.vtkUTF16TextCodec_Name_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601340B RID: 78859
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUTF16TextCodec_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601340C RID: 78860 RVA: 0x001B39DC File Offset: 0x001B1BDC
		public new vtkUTF16TextCodec NewInstance()
		{
			vtkUTF16TextCodec result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUTF16TextCodec.vtkUTF16TextCodec_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUTF16TextCodec)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601340D RID: 78861
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUTF16TextCodec_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601340E RID: 78862 RVA: 0x001B3A38 File Offset: 0x001B1C38
		public new static vtkUTF16TextCodec SafeDownCast(vtkObjectBase o)
		{
			vtkUTF16TextCodec vtkUTF16TextCodec = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUTF16TextCodec.vtkUTF16TextCodec_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUTF16TextCodec = (vtkUTF16TextCodec)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUTF16TextCodec.Register(null);
				}
			}
			return vtkUTF16TextCodec;
		}

		// Token: 0x0601340F RID: 78863
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkUTF16TextCodec_SetBigEndian_10(HandleRef pThis, byte arg0);

		/// <summary>
		/// Set the endianness - true if Big false is little
		/// </summary>
		// Token: 0x06013410 RID: 78864 RVA: 0x001B3AB7 File Offset: 0x001B1CB7
		public void SetBigEndian(bool arg0)
		{
			vtkUTF16TextCodec.vtkUTF16TextCodec_SetBigEndian_10(base.GetCppThis(), arg0 ? (byte)1 : (byte)0);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400163A RID: 5690
		public new const string MRFullTypeName = "Kitware.VTK.vtkUTF16TextCodec";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400163B RID: 5691
		public new static readonly string MRClassNameKey = "class vtkUTF16TextCodec";
	}
}
