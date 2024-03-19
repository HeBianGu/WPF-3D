using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkJSONImageWriter
	/// </summary>
	/// <remarks>
	///    Writes vtkImageData to a JSON file.
	///
	/// vtkJSONImageWriter writes a JSON file which will describe the
	/// data inside a vtkImageData.
	/// </remarks>
	// Token: 0x0200078A RID: 1930
	public class vtkJSONImageWriter : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013D02 RID: 81154 RVA: 0x001C0164 File Offset: 0x001BE364
		static vtkJSONImageWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkJSONImageWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkJSONImageWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013D03 RID: 81155 RVA: 0x001C018C File Offset: 0x001BE38C
		public vtkJSONImageWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013D04 RID: 81156
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJSONImageWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013D05 RID: 81157 RVA: 0x001C019C File Offset: 0x001BE39C
		public new static vtkJSONImageWriter New()
		{
			vtkJSONImageWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkJSONImageWriter.vtkJSONImageWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkJSONImageWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013D06 RID: 81158 RVA: 0x001C01F0 File Offset: 0x001BE3F0
		public vtkJSONImageWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkJSONImageWriter.vtkJSONImageWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013D07 RID: 81159 RVA: 0x001C0234 File Offset: 0x001BE434
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013D08 RID: 81160
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJSONImageWriter_GetArrayName_01(HandleRef pThis);

		/// <summary>
		/// Specify ArrayName to export. By default nullptr which will dump ALL arrays.
		/// </summary>
		// Token: 0x06013D09 RID: 81161 RVA: 0x001C0240 File Offset: 0x001BE440
		public virtual string GetArrayName()
		{
			string s = Marshal.PtrToStringAnsi(vtkJSONImageWriter.vtkJSONImageWriter_GetArrayName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013D0A RID: 81162
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJSONImageWriter_GetFileName_02(HandleRef pThis);

		/// <summary>
		/// Specify file name for the image file.
		/// </summary>
		// Token: 0x06013D0B RID: 81163 RVA: 0x001C027C File Offset: 0x001BE47C
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkJSONImageWriter.vtkJSONImageWriter_GetFileName_02(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013D0C RID: 81164
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkJSONImageWriter_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013D0D RID: 81165 RVA: 0x001C02B8 File Offset: 0x001BE4B8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkJSONImageWriter.vtkJSONImageWriter_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06013D0E RID: 81166
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkJSONImageWriter_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013D0F RID: 81167 RVA: 0x001C02D8 File Offset: 0x001BE4D8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkJSONImageWriter.vtkJSONImageWriter_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06013D10 RID: 81168
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkJSONImageWriter_GetSlice_05(HandleRef pThis);

		/// <summary>
		/// Specify Slice in Z to export. By default -1 which will dump the full 3D domain.
		/// </summary>
		// Token: 0x06013D11 RID: 81169 RVA: 0x001C02F4 File Offset: 0x001BE4F4
		public virtual int GetSlice()
		{
			return vtkJSONImageWriter.vtkJSONImageWriter_GetSlice_05(base.GetCppThis());
		}

		// Token: 0x06013D12 RID: 81170
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkJSONImageWriter_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013D13 RID: 81171 RVA: 0x001C0314 File Offset: 0x001BE514
		public override int IsA(string type)
		{
			return vtkJSONImageWriter.vtkJSONImageWriter_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06013D14 RID: 81172
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkJSONImageWriter_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013D15 RID: 81173 RVA: 0x001C0334 File Offset: 0x001BE534
		public new static int IsTypeOf(string type)
		{
			return vtkJSONImageWriter.vtkJSONImageWriter_IsTypeOf_07(type);
		}

		// Token: 0x06013D16 RID: 81174
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJSONImageWriter_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013D17 RID: 81175 RVA: 0x001C0350 File Offset: 0x001BE550
		public new vtkJSONImageWriter NewInstance()
		{
			vtkJSONImageWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkJSONImageWriter.vtkJSONImageWriter_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkJSONImageWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013D18 RID: 81176
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkJSONImageWriter_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013D19 RID: 81177 RVA: 0x001C03AC File Offset: 0x001BE5AC
		public new static vtkJSONImageWriter SafeDownCast(vtkObjectBase o)
		{
			vtkJSONImageWriter vtkJSONImageWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkJSONImageWriter.vtkJSONImageWriter_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkJSONImageWriter = (vtkJSONImageWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkJSONImageWriter.Register(null);
				}
			}
			return vtkJSONImageWriter;
		}

		// Token: 0x06013D1A RID: 81178
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJSONImageWriter_SetArrayName_11(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify ArrayName to export. By default nullptr which will dump ALL arrays.
		/// </summary>
		// Token: 0x06013D1B RID: 81179 RVA: 0x001C042B File Offset: 0x001BE62B
		public virtual void SetArrayName(string _arg)
		{
			vtkJSONImageWriter.vtkJSONImageWriter_SetArrayName_11(base.GetCppThis(), _arg);
		}

		// Token: 0x06013D1C RID: 81180
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJSONImageWriter_SetFileName_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Specify file name for the image file.
		/// </summary>
		// Token: 0x06013D1D RID: 81181 RVA: 0x001C043B File Offset: 0x001BE63B
		public virtual void SetFileName(string _arg)
		{
			vtkJSONImageWriter.vtkJSONImageWriter_SetFileName_12(base.GetCppThis(), _arg);
		}

		// Token: 0x06013D1E RID: 81182
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJSONImageWriter_SetSlice_13(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify Slice in Z to export. By default -1 which will dump the full 3D domain.
		/// </summary>
		// Token: 0x06013D1F RID: 81183 RVA: 0x001C044B File Offset: 0x001BE64B
		public virtual void SetSlice(int _arg)
		{
			vtkJSONImageWriter.vtkJSONImageWriter_SetSlice_13(base.GetCppThis(), _arg);
		}

		// Token: 0x06013D20 RID: 81184
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkJSONImageWriter_Write_14(HandleRef pThis);

		/// <summary>
		/// The main interface which triggers the writer to start.
		/// </summary>
		// Token: 0x06013D21 RID: 81185 RVA: 0x001C045B File Offset: 0x001BE65B
		public virtual void Write()
		{
			vtkJSONImageWriter.vtkJSONImageWriter_Write_14(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016C6 RID: 5830
		public new const string MRFullTypeName = "Kitware.VTK.vtkJSONImageWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016C7 RID: 5831
		public new static readonly string MRClassNameKey = "class vtkJSONImageWriter";
	}
}
