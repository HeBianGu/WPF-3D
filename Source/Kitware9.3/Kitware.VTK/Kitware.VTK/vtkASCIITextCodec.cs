using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkASCIITextCodec
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
	/// vtkASCIITextCodecFactory
	///
	/// </seealso>
	// Token: 0x02000721 RID: 1825
	public class vtkASCIITextCodec : vtkTextCodec
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013192 RID: 78226 RVA: 0x001AFD17 File Offset: 0x001ADF17
		static vtkASCIITextCodec()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkASCIITextCodec.MRClassNameKey, Type.GetType("Kitware.VTK.vtkASCIITextCodec"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013193 RID: 78227 RVA: 0x001AFD3F File Offset: 0x001ADF3F
		public vtkASCIITextCodec(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013194 RID: 78228
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkASCIITextCodec_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013195 RID: 78229 RVA: 0x001AFD50 File Offset: 0x001ADF50
		public new static vtkASCIITextCodec New()
		{
			vtkASCIITextCodec result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkASCIITextCodec.vtkASCIITextCodec_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkASCIITextCodec)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013196 RID: 78230 RVA: 0x001AFDA4 File Offset: 0x001ADFA4
		public vtkASCIITextCodec() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkASCIITextCodec.vtkASCIITextCodec_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013197 RID: 78231 RVA: 0x001AFDE8 File Offset: 0x001ADFE8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013198 RID: 78232
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkASCIITextCodec_CanHandle_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string NameString);

		/// <summary>
		/// The name this codec goes by - should match the string the factory will take to create it
		/// </summary>
		// Token: 0x06013199 RID: 78233 RVA: 0x001AFDF4 File Offset: 0x001ADFF4
		public override bool CanHandle(string NameString)
		{
			return vtkASCIITextCodec.vtkASCIITextCodec_CanHandle_01(base.GetCppThis(), NameString) != 0;
		}

		// Token: 0x0601319A RID: 78234
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkASCIITextCodec_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601319B RID: 78235 RVA: 0x001AFE1C File Offset: 0x001AE01C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkASCIITextCodec.vtkASCIITextCodec_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601319C RID: 78236
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkASCIITextCodec_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601319D RID: 78237 RVA: 0x001AFE3C File Offset: 0x001AE03C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkASCIITextCodec.vtkASCIITextCodec_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601319E RID: 78238
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkASCIITextCodec_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601319F RID: 78239 RVA: 0x001AFE58 File Offset: 0x001AE058
		public override int IsA(string type)
		{
			return vtkASCIITextCodec.vtkASCIITextCodec_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x060131A0 RID: 78240
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkASCIITextCodec_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060131A1 RID: 78241 RVA: 0x001AFE78 File Offset: 0x001AE078
		public new static int IsTypeOf(string type)
		{
			return vtkASCIITextCodec.vtkASCIITextCodec_IsTypeOf_05(type);
		}

		// Token: 0x060131A2 RID: 78242
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkASCIITextCodec_Name_06(HandleRef pThis);

		/// <summary>
		/// The name this codec goes by - should match the string the factory will take to create it
		/// </summary>
		// Token: 0x060131A3 RID: 78243 RVA: 0x001AFE94 File Offset: 0x001AE094
		public override string Name()
		{
			string s = Marshal.PtrToStringAnsi(vtkASCIITextCodec.vtkASCIITextCodec_Name_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060131A4 RID: 78244
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkASCIITextCodec_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060131A5 RID: 78245 RVA: 0x001AFED0 File Offset: 0x001AE0D0
		public new vtkASCIITextCodec NewInstance()
		{
			vtkASCIITextCodec result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkASCIITextCodec.vtkASCIITextCodec_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkASCIITextCodec)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060131A6 RID: 78246
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkASCIITextCodec_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060131A7 RID: 78247 RVA: 0x001AFF2C File Offset: 0x001AE12C
		public new static vtkASCIITextCodec SafeDownCast(vtkObjectBase o)
		{
			vtkASCIITextCodec vtkASCIITextCodec = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkASCIITextCodec.vtkASCIITextCodec_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkASCIITextCodec = (vtkASCIITextCodec)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkASCIITextCodec.Register(null);
				}
			}
			return vtkASCIITextCodec;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400160E RID: 5646
		public new const string MRFullTypeName = "Kitware.VTK.vtkASCIITextCodec";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400160F RID: 5647
		public new static readonly string MRClassNameKey = "class vtkASCIITextCodec";
	}
}
