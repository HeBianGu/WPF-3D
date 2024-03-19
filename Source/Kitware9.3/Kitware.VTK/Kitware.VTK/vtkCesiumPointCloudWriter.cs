using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCesiumPointCloudWriter
	/// </summary>
	/// <remarks>
	///    export a vtkPointSet into a Cesium Point Cloud tile format
	///
	/// </remarks>
	// Token: 0x020001D7 RID: 471
	public class vtkCesiumPointCloudWriter : vtkWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005A70 RID: 23152 RVA: 0x00082B59 File Offset: 0x00080D59
		static vtkCesiumPointCloudWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCesiumPointCloudWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCesiumPointCloudWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005A71 RID: 23153 RVA: 0x00082B81 File Offset: 0x00080D81
		public vtkCesiumPointCloudWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06005A72 RID: 23154
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCesiumPointCloudWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005A73 RID: 23155 RVA: 0x00082B90 File Offset: 0x00080D90
		public new static vtkCesiumPointCloudWriter New()
		{
			vtkCesiumPointCloudWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCesiumPointCloudWriter.vtkCesiumPointCloudWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCesiumPointCloudWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005A74 RID: 23156 RVA: 0x00082BE4 File Offset: 0x00080DE4
		public vtkCesiumPointCloudWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCesiumPointCloudWriter.vtkCesiumPointCloudWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005A75 RID: 23157 RVA: 0x00082C28 File Offset: 0x00080E28
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005A76 RID: 23158
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCesiumPointCloudWriter_GetFileName_01(HandleRef pThis);

		/// <summary>
		/// Name of the file to write.
		/// </summary>
		// Token: 0x06005A77 RID: 23159 RVA: 0x00082C34 File Offset: 0x00080E34
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkCesiumPointCloudWriter.vtkCesiumPointCloudWriter_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06005A78 RID: 23160
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCesiumPointCloudWriter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005A79 RID: 23161 RVA: 0x00082C70 File Offset: 0x00080E70
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCesiumPointCloudWriter.vtkCesiumPointCloudWriter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06005A7A RID: 23162
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCesiumPointCloudWriter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005A7B RID: 23163 RVA: 0x00082C90 File Offset: 0x00080E90
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCesiumPointCloudWriter.vtkCesiumPointCloudWriter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06005A7C RID: 23164
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCesiumPointCloudWriter_GetPointIds_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// List of points to be saved.
		/// </summary>
		// Token: 0x06005A7D RID: 23165 RVA: 0x00082CAC File Offset: 0x00080EAC
		public virtual vtkIdList GetPointIds()
		{
			vtkIdList vtkIdList = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCesiumPointCloudWriter.vtkCesiumPointCloudWriter_GetPointIds_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkIdList = (vtkIdList)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkIdList.Register(null);
				}
			}
			return vtkIdList;
		}

		// Token: 0x06005A7E RID: 23166
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCesiumPointCloudWriter_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005A7F RID: 23167 RVA: 0x00082D1C File Offset: 0x00080F1C
		public override int IsA(string type)
		{
			return vtkCesiumPointCloudWriter.vtkCesiumPointCloudWriter_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06005A80 RID: 23168
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCesiumPointCloudWriter_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005A81 RID: 23169 RVA: 0x00082D3C File Offset: 0x00080F3C
		public new static int IsTypeOf(string type)
		{
			return vtkCesiumPointCloudWriter.vtkCesiumPointCloudWriter_IsTypeOf_06(type);
		}

		// Token: 0x06005A82 RID: 23170
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCesiumPointCloudWriter_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005A83 RID: 23171 RVA: 0x00082D58 File Offset: 0x00080F58
		public new vtkCesiumPointCloudWriter NewInstance()
		{
			vtkCesiumPointCloudWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCesiumPointCloudWriter.vtkCesiumPointCloudWriter_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCesiumPointCloudWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005A84 RID: 23172
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCesiumPointCloudWriter_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005A85 RID: 23173 RVA: 0x00082DB4 File Offset: 0x00080FB4
		public new static vtkCesiumPointCloudWriter SafeDownCast(vtkObjectBase o)
		{
			vtkCesiumPointCloudWriter vtkCesiumPointCloudWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCesiumPointCloudWriter.vtkCesiumPointCloudWriter_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCesiumPointCloudWriter = (vtkCesiumPointCloudWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCesiumPointCloudWriter.Register(null);
				}
			}
			return vtkCesiumPointCloudWriter;
		}

		// Token: 0x06005A86 RID: 23174
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCesiumPointCloudWriter_SetFileName_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Name of the file to write.
		/// </summary>
		// Token: 0x06005A87 RID: 23175 RVA: 0x00082E33 File Offset: 0x00081033
		public virtual void SetFileName(string _arg)
		{
			vtkCesiumPointCloudWriter.vtkCesiumPointCloudWriter_SetFileName_10(base.GetCppThis(), _arg);
		}

		// Token: 0x06005A88 RID: 23176
		[DllImport("Kitware.VTK.IOCesium3DTiles.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCesiumPointCloudWriter_SetPointIds_11(HandleRef pThis, HandleRef _arg);

		/// <summary>
		/// List of points to be saved.
		/// </summary>
		// Token: 0x06005A89 RID: 23177 RVA: 0x00082E44 File Offset: 0x00081044
		public virtual void SetPointIds(vtkIdList _arg)
		{
			vtkCesiumPointCloudWriter.vtkCesiumPointCloudWriter_SetPointIds_11(base.GetCppThis(), (_arg == null) ? default(HandleRef) : _arg.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000877 RID: 2167
		public new const string MRFullTypeName = "Kitware.VTK.vtkCesiumPointCloudWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000878 RID: 2168
		public new static readonly string MRClassNameKey = "class vtkCesiumPointCloudWriter";
	}
}
