using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSimplePointsWriter
	/// </summary>
	/// <remarks>
	///    write a file of xyz coordinates
	///
	/// vtkSimplePointsWriter writes a simple file of xyz coordinates
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkSimplePointsReader
	/// </seealso>
	// Token: 0x02000711 RID: 1809
	public class vtkSimplePointsWriter : vtkDataSetWriter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06012FAE RID: 77742 RVA: 0x001AC86F File Offset: 0x001AAA6F
		static vtkSimplePointsWriter()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSimplePointsWriter.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSimplePointsWriter"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06012FAF RID: 77743 RVA: 0x001AC897 File Offset: 0x001AAA97
		public vtkSimplePointsWriter(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06012FB0 RID: 77744
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimplePointsWriter_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012FB1 RID: 77745 RVA: 0x001AC8A8 File Offset: 0x001AAAA8
		public new static vtkSimplePointsWriter New()
		{
			vtkSimplePointsWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSimplePointsWriter.vtkSimplePointsWriter_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSimplePointsWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012FB2 RID: 77746 RVA: 0x001AC8FC File Offset: 0x001AAAFC
		public vtkSimplePointsWriter() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSimplePointsWriter.vtkSimplePointsWriter_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06012FB3 RID: 77747 RVA: 0x001AC940 File Offset: 0x001AAB40
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06012FB4 RID: 77748
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimplePointsWriter_GetDecimalPrecision_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012FB5 RID: 77749 RVA: 0x001AC94C File Offset: 0x001AAB4C
		public virtual int GetDecimalPrecision()
		{
			return vtkSimplePointsWriter.vtkSimplePointsWriter_GetDecimalPrecision_01(base.GetCppThis());
		}

		// Token: 0x06012FB6 RID: 77750
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSimplePointsWriter_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012FB7 RID: 77751 RVA: 0x001AC96C File Offset: 0x001AAB6C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSimplePointsWriter.vtkSimplePointsWriter_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06012FB8 RID: 77752
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSimplePointsWriter_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012FB9 RID: 77753 RVA: 0x001AC98C File Offset: 0x001AAB8C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSimplePointsWriter.vtkSimplePointsWriter_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06012FBA RID: 77754
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimplePointsWriter_IsA_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012FBB RID: 77755 RVA: 0x001AC9A8 File Offset: 0x001AABA8
		public override int IsA(string type)
		{
			return vtkSimplePointsWriter.vtkSimplePointsWriter_IsA_04(base.GetCppThis(), type);
		}

		// Token: 0x06012FBC RID: 77756
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSimplePointsWriter_IsTypeOf_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012FBD RID: 77757 RVA: 0x001AC9C8 File Offset: 0x001AABC8
		public new static int IsTypeOf(string type)
		{
			return vtkSimplePointsWriter.vtkSimplePointsWriter_IsTypeOf_05(type);
		}

		// Token: 0x06012FBE RID: 77758
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimplePointsWriter_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012FBF RID: 77759 RVA: 0x001AC9E4 File Offset: 0x001AABE4
		public new vtkSimplePointsWriter NewInstance()
		{
			vtkSimplePointsWriter result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSimplePointsWriter.vtkSimplePointsWriter_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSimplePointsWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06012FC0 RID: 77760
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSimplePointsWriter_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012FC1 RID: 77761 RVA: 0x001ACA40 File Offset: 0x001AAC40
		public new static vtkSimplePointsWriter SafeDownCast(vtkObjectBase o)
		{
			vtkSimplePointsWriter vtkSimplePointsWriter = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSimplePointsWriter.vtkSimplePointsWriter_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSimplePointsWriter = (vtkSimplePointsWriter)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSimplePointsWriter.Register(null);
				}
			}
			return vtkSimplePointsWriter;
		}

		// Token: 0x06012FC2 RID: 77762
		[DllImport("Kitware.VTK.IOLegacy.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSimplePointsWriter_SetDecimalPrecision_09(HandleRef pThis, int _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06012FC3 RID: 77763 RVA: 0x001ACABF File Offset: 0x001AACBF
		public virtual void SetDecimalPrecision(int _arg)
		{
			vtkSimplePointsWriter.vtkSimplePointsWriter_SetDecimalPrecision_09(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015EE RID: 5614
		public new const string MRFullTypeName = "Kitware.VTK.vtkSimplePointsWriter";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040015EF RID: 5615
		public new static readonly string MRClassNameKey = "class vtkSimplePointsWriter";
	}
}
