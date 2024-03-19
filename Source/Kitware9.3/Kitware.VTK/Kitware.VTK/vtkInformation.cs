using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInformation
	/// </summary>
	/// <remarks>
	///    Store vtkAlgorithm input/output information.
	///
	/// vtkInformation represents information and/or data for one input or
	/// one output of a vtkAlgorithm.  It maps from keys to values of
	/// several data types.  Instances of this class are collected in
	/// vtkInformationVector instances and passed to
	/// vtkAlgorithm::ProcessRequest calls.  The information and
	/// data referenced by the instance on a particular input or output
	/// define the request made to the vtkAlgorithm instance.
	/// </remarks>
	// Token: 0x02000B58 RID: 2904
	public class vtkInformation : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601E516 RID: 124182 RVA: 0x002AE47B File Offset: 0x002AC67B
		static vtkInformation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInformation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInformation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601E517 RID: 124183 RVA: 0x002AE4A3 File Offset: 0x002AC6A3
		public vtkInformation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601E518 RID: 124184
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E519 RID: 124185 RVA: 0x002AE4B4 File Offset: 0x002AC6B4
		public new static vtkInformation New()
		{
			vtkInformation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformation.vtkInformation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E51A RID: 124186 RVA: 0x002AE508 File Offset: 0x002AC708
		public vtkInformation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkInformation.vtkInformation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601E51B RID: 124187 RVA: 0x002AE54C File Offset: 0x002AC74C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601E51C RID: 124188
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Append_01(HandleRef pThis, HandleRef key, HandleRef value);

		/// <summary>
		/// Get/Set an variant-vector-valued entry.
		/// </summary>
		// Token: 0x0601E51D RID: 124189 RVA: 0x002AE558 File Offset: 0x002AC758
		public void Append(vtkInformationVariantVectorKey key, vtkVariant value)
		{
			vtkInformation.vtkInformation_Append_01(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E51E RID: 124190
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Append_02(HandleRef pThis, HandleRef key, HandleRef value);

		/// <summary>
		/// Get/Set an InformationKey-vector-valued entry.
		/// </summary>
		// Token: 0x0601E51F RID: 124191 RVA: 0x002AE59C File Offset: 0x002AC79C
		public void Append(vtkInformationKeyVectorKey key, vtkInformationKey value)
		{
			vtkInformation.vtkInformation_Append_02(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E520 RID: 124192
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Append_03(HandleRef pThis, HandleRef key, HandleRef value);

		/// <summary>
		/// Get/Set an InformationKey-vector-valued entry.
		/// </summary>
		// Token: 0x0601E521 RID: 124193 RVA: 0x002AE5E0 File Offset: 0x002AC7E0
		public void Append(vtkInformationKeyVectorKey key, vtkInformationDataObjectKey value)
		{
			vtkInformation.vtkInformation_Append_03(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E522 RID: 124194
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Append_04(HandleRef pThis, HandleRef key, HandleRef value);

		/// <summary>
		/// Get/Set an InformationKey-vector-valued entry.
		/// </summary>
		// Token: 0x0601E523 RID: 124195 RVA: 0x002AE624 File Offset: 0x002AC824
		public void Append(vtkInformationKeyVectorKey key, vtkInformationDoubleKey value)
		{
			vtkInformation.vtkInformation_Append_04(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E524 RID: 124196
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Append_05(HandleRef pThis, HandleRef key, HandleRef value);

		/// <summary>
		/// Get/Set an InformationKey-vector-valued entry.
		/// </summary>
		// Token: 0x0601E525 RID: 124197 RVA: 0x002AE668 File Offset: 0x002AC868
		public void Append(vtkInformationKeyVectorKey key, vtkInformationDoubleVectorKey value)
		{
			vtkInformation.vtkInformation_Append_05(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E526 RID: 124198
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Append_06(HandleRef pThis, HandleRef key, HandleRef value);

		/// <summary>
		/// Get/Set an InformationKey-vector-valued entry.
		/// </summary>
		// Token: 0x0601E527 RID: 124199 RVA: 0x002AE6AC File Offset: 0x002AC8AC
		public void Append(vtkInformationKeyVectorKey key, vtkInformationInformationKey value)
		{
			vtkInformation.vtkInformation_Append_06(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E528 RID: 124200
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Append_07(HandleRef pThis, HandleRef key, HandleRef value);

		/// <summary>
		/// Get/Set an InformationKey-vector-valued entry.
		/// </summary>
		// Token: 0x0601E529 RID: 124201 RVA: 0x002AE6F0 File Offset: 0x002AC8F0
		public void Append(vtkInformationKeyVectorKey key, vtkInformationInformationVectorKey value)
		{
			vtkInformation.vtkInformation_Append_07(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E52A RID: 124202
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Append_08(HandleRef pThis, HandleRef key, HandleRef value);

		/// <summary>
		/// Get/Set an InformationKey-vector-valued entry.
		/// </summary>
		// Token: 0x0601E52B RID: 124203 RVA: 0x002AE734 File Offset: 0x002AC934
		public void Append(vtkInformationKeyVectorKey key, vtkInformationIntegerKey value)
		{
			vtkInformation.vtkInformation_Append_08(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E52C RID: 124204
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Append_09(HandleRef pThis, HandleRef key, HandleRef value);

		/// <summary>
		/// Get/Set an InformationKey-vector-valued entry.
		/// </summary>
		// Token: 0x0601E52D RID: 124205 RVA: 0x002AE778 File Offset: 0x002AC978
		public void Append(vtkInformationKeyVectorKey key, vtkInformationIntegerVectorKey value)
		{
			vtkInformation.vtkInformation_Append_09(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E52E RID: 124206
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Append_10(HandleRef pThis, HandleRef key, HandleRef value);

		/// <summary>
		/// Get/Set an InformationKey-vector-valued entry.
		/// </summary>
		// Token: 0x0601E52F RID: 124207 RVA: 0x002AE7BC File Offset: 0x002AC9BC
		public void Append(vtkInformationKeyVectorKey key, vtkInformationStringKey value)
		{
			vtkInformation.vtkInformation_Append_10(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E530 RID: 124208
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Append_11(HandleRef pThis, HandleRef key, HandleRef value);

		/// <summary>
		/// Get/Set an InformationKey-vector-valued entry.
		/// </summary>
		// Token: 0x0601E531 RID: 124209 RVA: 0x002AE800 File Offset: 0x002ACA00
		public void Append(vtkInformationKeyVectorKey key, vtkInformationStringVectorKey value)
		{
			vtkInformation.vtkInformation_Append_11(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E532 RID: 124210
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Append_12(HandleRef pThis, HandleRef key, HandleRef value);

		/// <summary>
		/// Get/Set an InformationKey-vector-valued entry.
		/// </summary>
		// Token: 0x0601E533 RID: 124211 RVA: 0x002AE844 File Offset: 0x002ACA44
		public void Append(vtkInformationKeyVectorKey key, vtkInformationObjectBaseKey value)
		{
			vtkInformation.vtkInformation_Append_12(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E534 RID: 124212
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Append_13(HandleRef pThis, HandleRef key, HandleRef value);

		/// <summary>
		/// Get/Set an InformationKey-vector-valued entry.
		/// </summary>
		// Token: 0x0601E535 RID: 124213 RVA: 0x002AE888 File Offset: 0x002ACA88
		public void Append(vtkInformationKeyVectorKey key, vtkInformationUnsignedLongKey value)
		{
			vtkInformation.vtkInformation_Append_13(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E536 RID: 124214
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Append_14(HandleRef pThis, HandleRef key, HandleRef data);

		/// <summary>
		/// Manipulate a ObjectBaseVector entry.
		/// </summary>
		// Token: 0x0601E537 RID: 124215 RVA: 0x002AE8CC File Offset: 0x002ACACC
		public void Append(vtkInformationObjectBaseVectorKey key, vtkObjectBase data)
		{
			vtkInformation.vtkInformation_Append_14(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis());
		}

		// Token: 0x0601E538 RID: 124216
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Append_15(HandleRef pThis, HandleRef from, int deep);

		/// <summary>
		/// Append all information entries from the given vtkInformation
		/// instance. If deep==1, a deep copy of the information structure is performed
		/// (new instances of any contained vtkInformation and vtkInformationVector
		/// objects are created).
		/// </summary>
		// Token: 0x0601E539 RID: 124217 RVA: 0x002AE910 File Offset: 0x002ACB10
		public void Append(vtkInformation from, int deep)
		{
			vtkInformation.vtkInformation_Append_15(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), deep);
		}

		// Token: 0x0601E53A RID: 124218
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Append_16(HandleRef pThis, HandleRef key, int value);

		/// <summary>
		/// Get/Set an integer-vector-valued entry.
		/// </summary>
		// Token: 0x0601E53B RID: 124219 RVA: 0x002AE940 File Offset: 0x002ACB40
		public void Append(vtkInformationIntegerVectorKey key, int value)
		{
			vtkInformation.vtkInformation_Append_16(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value);
		}

		// Token: 0x0601E53C RID: 124220
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Append_17(HandleRef pThis, HandleRef key, [MarshalAs(UnmanagedType.LPUTF8Str)] string value);

		/// <summary>
		/// Get/Set a string-vector-valued entry.
		/// </summary>
		// Token: 0x0601E53D RID: 124221 RVA: 0x002AE970 File Offset: 0x002ACB70
		public void Append(vtkInformationStringVectorKey key, string value)
		{
			vtkInformation.vtkInformation_Append_17(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value);
		}

		// Token: 0x0601E53E RID: 124222
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Append_18(HandleRef pThis, HandleRef key, double value);

		/// <summary>
		/// Get/Set an double-vector-valued entry.
		/// </summary>
		// Token: 0x0601E53F RID: 124223 RVA: 0x002AE9A0 File Offset: 0x002ACBA0
		public void Append(vtkInformationDoubleVectorKey key, double value)
		{
			vtkInformation.vtkInformation_Append_18(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value);
		}

		// Token: 0x0601E540 RID: 124224
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_AppendUnique_19(HandleRef pThis, HandleRef key, HandleRef value);

		/// <summary>
		/// Get/Set an InformationKey-vector-valued entry.
		/// </summary>
		// Token: 0x0601E541 RID: 124225 RVA: 0x002AE9D0 File Offset: 0x002ACBD0
		public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationKey value)
		{
			vtkInformation.vtkInformation_AppendUnique_19(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E542 RID: 124226
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_AppendUnique_20(HandleRef pThis, HandleRef key, HandleRef value);

		/// <summary>
		/// Get/Set an InformationKey-vector-valued entry.
		/// </summary>
		// Token: 0x0601E543 RID: 124227 RVA: 0x002AEA14 File Offset: 0x002ACC14
		public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationDataObjectKey value)
		{
			vtkInformation.vtkInformation_AppendUnique_20(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E544 RID: 124228
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_AppendUnique_21(HandleRef pThis, HandleRef key, HandleRef value);

		/// <summary>
		/// Get/Set an InformationKey-vector-valued entry.
		/// </summary>
		// Token: 0x0601E545 RID: 124229 RVA: 0x002AEA58 File Offset: 0x002ACC58
		public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationDoubleKey value)
		{
			vtkInformation.vtkInformation_AppendUnique_21(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E546 RID: 124230
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_AppendUnique_22(HandleRef pThis, HandleRef key, HandleRef value);

		/// <summary>
		/// Get/Set an InformationKey-vector-valued entry.
		/// </summary>
		// Token: 0x0601E547 RID: 124231 RVA: 0x002AEA9C File Offset: 0x002ACC9C
		public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationDoubleVectorKey value)
		{
			vtkInformation.vtkInformation_AppendUnique_22(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E548 RID: 124232
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_AppendUnique_23(HandleRef pThis, HandleRef key, HandleRef value);

		/// <summary>
		/// Get/Set an InformationKey-vector-valued entry.
		/// </summary>
		// Token: 0x0601E549 RID: 124233 RVA: 0x002AEAE0 File Offset: 0x002ACCE0
		public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationInformationKey value)
		{
			vtkInformation.vtkInformation_AppendUnique_23(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E54A RID: 124234
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_AppendUnique_24(HandleRef pThis, HandleRef key, HandleRef value);

		/// <summary>
		/// Get/Set an InformationKey-vector-valued entry.
		/// </summary>
		// Token: 0x0601E54B RID: 124235 RVA: 0x002AEB24 File Offset: 0x002ACD24
		public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationInformationVectorKey value)
		{
			vtkInformation.vtkInformation_AppendUnique_24(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E54C RID: 124236
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_AppendUnique_25(HandleRef pThis, HandleRef key, HandleRef value);

		/// <summary>
		/// Get/Set an InformationKey-vector-valued entry.
		/// </summary>
		// Token: 0x0601E54D RID: 124237 RVA: 0x002AEB68 File Offset: 0x002ACD68
		public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationIntegerKey value)
		{
			vtkInformation.vtkInformation_AppendUnique_25(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E54E RID: 124238
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_AppendUnique_26(HandleRef pThis, HandleRef key, HandleRef value);

		/// <summary>
		/// Get/Set an InformationKey-vector-valued entry.
		/// </summary>
		// Token: 0x0601E54F RID: 124239 RVA: 0x002AEBAC File Offset: 0x002ACDAC
		public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationIntegerVectorKey value)
		{
			vtkInformation.vtkInformation_AppendUnique_26(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E550 RID: 124240
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_AppendUnique_27(HandleRef pThis, HandleRef key, HandleRef value);

		/// <summary>
		/// Get/Set an InformationKey-vector-valued entry.
		/// </summary>
		// Token: 0x0601E551 RID: 124241 RVA: 0x002AEBF0 File Offset: 0x002ACDF0
		public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationStringKey value)
		{
			vtkInformation.vtkInformation_AppendUnique_27(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E552 RID: 124242
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_AppendUnique_28(HandleRef pThis, HandleRef key, HandleRef value);

		/// <summary>
		/// Get/Set an InformationKey-vector-valued entry.
		/// </summary>
		// Token: 0x0601E553 RID: 124243 RVA: 0x002AEC34 File Offset: 0x002ACE34
		public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationStringVectorKey value)
		{
			vtkInformation.vtkInformation_AppendUnique_28(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E554 RID: 124244
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_AppendUnique_29(HandleRef pThis, HandleRef key, HandleRef value);

		/// <summary>
		/// Get/Set an InformationKey-vector-valued entry.
		/// </summary>
		// Token: 0x0601E555 RID: 124245 RVA: 0x002AEC78 File Offset: 0x002ACE78
		public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationObjectBaseKey value)
		{
			vtkInformation.vtkInformation_AppendUnique_29(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E556 RID: 124246
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_AppendUnique_30(HandleRef pThis, HandleRef key, HandleRef value);

		/// <summary>
		/// Get/Set an InformationKey-vector-valued entry.
		/// </summary>
		// Token: 0x0601E557 RID: 124247 RVA: 0x002AECBC File Offset: 0x002ACEBC
		public void AppendUnique(vtkInformationKeyVectorKey key, vtkInformationUnsignedLongKey value)
		{
			vtkInformation.vtkInformation_AppendUnique_30(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E558 RID: 124248
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Clear_31(HandleRef pThis);

		/// <summary>
		/// Clear all information entries.
		/// </summary>
		// Token: 0x0601E559 RID: 124249 RVA: 0x002AED00 File Offset: 0x002ACF00
		public void Clear()
		{
			vtkInformation.vtkInformation_Clear_31(base.GetCppThis());
		}

		// Token: 0x0601E55A RID: 124250
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Copy_32(HandleRef pThis, HandleRef from, int deep);

		/// <summary>
		/// Copy all information entries from the given vtkInformation
		/// instance.  Any previously existing entries are removed.  If
		/// deep==1, a deep copy of the information structure is performed (new
		/// instances of any contained vtkInformation and vtkInformationVector
		/// objects are created).
		/// </summary>
		// Token: 0x0601E55B RID: 124251 RVA: 0x002AED10 File Offset: 0x002ACF10
		public void Copy(vtkInformation from, int deep)
		{
			vtkInformation.vtkInformation_Copy_32(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), deep);
		}

		// Token: 0x0601E55C RID: 124252
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_CopyEntries_33(HandleRef pThis, HandleRef from, HandleRef key, int deep);

		/// <summary>
		/// Use the given key to lookup a list of other keys in the given
		/// information object.  The key/value pairs associated with these
		/// other keys will be copied.  If deep==1, a deep copy of the
		/// information structure is performed.
		/// </summary>
		// Token: 0x0601E55D RID: 124253 RVA: 0x002AED40 File Offset: 0x002ACF40
		public void CopyEntries(vtkInformation from, vtkInformationKeyVectorKey key, int deep)
		{
			vtkInformation.vtkInformation_CopyEntries_33(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), deep);
		}

		// Token: 0x0601E55E RID: 124254
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_CopyEntry_34(HandleRef pThis, HandleRef from, HandleRef key, int deep);

		/// <summary>
		/// Copy the key/value pair associated with the given key in the
		/// given information object.  If deep=1, a deep copy of the information
		/// structure is performed (new instances of any contained vtkInformation and
		/// vtkInformationVector objects are created).
		/// </summary>
		// Token: 0x0601E55F RID: 124255 RVA: 0x002AED88 File Offset: 0x002ACF88
		public void CopyEntry(vtkInformation from, vtkInformationKey key, int deep)
		{
			vtkInformation.vtkInformation_CopyEntry_34(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), deep);
		}

		// Token: 0x0601E560 RID: 124256
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_CopyEntry_35(HandleRef pThis, HandleRef from, HandleRef key, int deep);

		/// <summary>
		/// Copy the key/value pair associated with the given key in the
		/// given information object.  If deep=1, a deep copy of the information
		/// structure is performed (new instances of any contained vtkInformation and
		/// vtkInformationVector objects are created).
		/// </summary>
		// Token: 0x0601E561 RID: 124257 RVA: 0x002AEDD0 File Offset: 0x002ACFD0
		public void CopyEntry(vtkInformation from, vtkInformationDataObjectKey key, int deep)
		{
			vtkInformation.vtkInformation_CopyEntry_35(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), deep);
		}

		// Token: 0x0601E562 RID: 124258
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_CopyEntry_36(HandleRef pThis, HandleRef from, HandleRef key, int deep);

		/// <summary>
		/// Copy the key/value pair associated with the given key in the
		/// given information object.  If deep=1, a deep copy of the information
		/// structure is performed (new instances of any contained vtkInformation and
		/// vtkInformationVector objects are created).
		/// </summary>
		// Token: 0x0601E563 RID: 124259 RVA: 0x002AEE18 File Offset: 0x002AD018
		public void CopyEntry(vtkInformation from, vtkInformationDoubleVectorKey key, int deep)
		{
			vtkInformation.vtkInformation_CopyEntry_36(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), deep);
		}

		// Token: 0x0601E564 RID: 124260
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_CopyEntry_37(HandleRef pThis, HandleRef from, HandleRef key, int deep);

		/// <summary>
		/// Copy the key/value pair associated with the given key in the
		/// given information object.  If deep=1, a deep copy of the information
		/// structure is performed (new instances of any contained vtkInformation and
		/// vtkInformationVector objects are created).
		/// </summary>
		// Token: 0x0601E565 RID: 124261 RVA: 0x002AEE60 File Offset: 0x002AD060
		public void CopyEntry(vtkInformation from, vtkInformationVariantKey key, int deep)
		{
			vtkInformation.vtkInformation_CopyEntry_37(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), deep);
		}

		// Token: 0x0601E566 RID: 124262
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_CopyEntry_38(HandleRef pThis, HandleRef from, HandleRef key, int deep);

		/// <summary>
		/// Copy the key/value pair associated with the given key in the
		/// given information object.  If deep=1, a deep copy of the information
		/// structure is performed (new instances of any contained vtkInformation and
		/// vtkInformationVector objects are created).
		/// </summary>
		// Token: 0x0601E567 RID: 124263 RVA: 0x002AEEA8 File Offset: 0x002AD0A8
		public void CopyEntry(vtkInformation from, vtkInformationVariantVectorKey key, int deep)
		{
			vtkInformation.vtkInformation_CopyEntry_38(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), deep);
		}

		// Token: 0x0601E568 RID: 124264
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_CopyEntry_39(HandleRef pThis, HandleRef from, HandleRef key, int deep);

		/// <summary>
		/// Copy the key/value pair associated with the given key in the
		/// given information object.  If deep=1, a deep copy of the information
		/// structure is performed (new instances of any contained vtkInformation and
		/// vtkInformationVector objects are created).
		/// </summary>
		// Token: 0x0601E569 RID: 124265 RVA: 0x002AEEF0 File Offset: 0x002AD0F0
		public void CopyEntry(vtkInformation from, vtkInformationInformationKey key, int deep)
		{
			vtkInformation.vtkInformation_CopyEntry_39(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), deep);
		}

		// Token: 0x0601E56A RID: 124266
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_CopyEntry_40(HandleRef pThis, HandleRef from, HandleRef key, int deep);

		/// <summary>
		/// Copy the key/value pair associated with the given key in the
		/// given information object.  If deep=1, a deep copy of the information
		/// structure is performed (new instances of any contained vtkInformation and
		/// vtkInformationVector objects are created).
		/// </summary>
		// Token: 0x0601E56B RID: 124267 RVA: 0x002AEF38 File Offset: 0x002AD138
		public void CopyEntry(vtkInformation from, vtkInformationInformationVectorKey key, int deep)
		{
			vtkInformation.vtkInformation_CopyEntry_40(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), deep);
		}

		// Token: 0x0601E56C RID: 124268
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_CopyEntry_41(HandleRef pThis, HandleRef from, HandleRef key, int deep);

		/// <summary>
		/// Copy the key/value pair associated with the given key in the
		/// given information object.  If deep=1, a deep copy of the information
		/// structure is performed (new instances of any contained vtkInformation and
		/// vtkInformationVector objects are created).
		/// </summary>
		// Token: 0x0601E56D RID: 124269 RVA: 0x002AEF80 File Offset: 0x002AD180
		public void CopyEntry(vtkInformation from, vtkInformationIntegerKey key, int deep)
		{
			vtkInformation.vtkInformation_CopyEntry_41(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), deep);
		}

		// Token: 0x0601E56E RID: 124270
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_CopyEntry_42(HandleRef pThis, HandleRef from, HandleRef key, int deep);

		/// <summary>
		/// Copy the key/value pair associated with the given key in the
		/// given information object.  If deep=1, a deep copy of the information
		/// structure is performed (new instances of any contained vtkInformation and
		/// vtkInformationVector objects are created).
		/// </summary>
		// Token: 0x0601E56F RID: 124271 RVA: 0x002AEFC8 File Offset: 0x002AD1C8
		public void CopyEntry(vtkInformation from, vtkInformationIntegerVectorKey key, int deep)
		{
			vtkInformation.vtkInformation_CopyEntry_42(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), deep);
		}

		// Token: 0x0601E570 RID: 124272
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_CopyEntry_43(HandleRef pThis, HandleRef from, HandleRef key, int deep);

		/// <summary>
		/// Copy the key/value pair associated with the given key in the
		/// given information object.  If deep=1, a deep copy of the information
		/// structure is performed (new instances of any contained vtkInformation and
		/// vtkInformationVector objects are created).
		/// </summary>
		// Token: 0x0601E571 RID: 124273 RVA: 0x002AF010 File Offset: 0x002AD210
		public void CopyEntry(vtkInformation from, vtkInformationObjectBaseVectorKey key, int deep)
		{
			vtkInformation.vtkInformation_CopyEntry_43(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), deep);
		}

		// Token: 0x0601E572 RID: 124274
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_CopyEntry_44(HandleRef pThis, HandleRef from, HandleRef key, int deep);

		/// <summary>
		/// Copy the key/value pair associated with the given key in the
		/// given information object.  If deep=1, a deep copy of the information
		/// structure is performed (new instances of any contained vtkInformation and
		/// vtkInformationVector objects are created).
		/// </summary>
		// Token: 0x0601E573 RID: 124275 RVA: 0x002AF058 File Offset: 0x002AD258
		public void CopyEntry(vtkInformation from, vtkInformationRequestKey key, int deep)
		{
			vtkInformation.vtkInformation_CopyEntry_44(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), deep);
		}

		// Token: 0x0601E574 RID: 124276
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_CopyEntry_45(HandleRef pThis, HandleRef from, HandleRef key, int deep);

		/// <summary>
		/// Copy the key/value pair associated with the given key in the
		/// given information object.  If deep=1, a deep copy of the information
		/// structure is performed (new instances of any contained vtkInformation and
		/// vtkInformationVector objects are created).
		/// </summary>
		// Token: 0x0601E575 RID: 124277 RVA: 0x002AF0A0 File Offset: 0x002AD2A0
		public void CopyEntry(vtkInformation from, vtkInformationStringKey key, int deep)
		{
			vtkInformation.vtkInformation_CopyEntry_45(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), deep);
		}

		// Token: 0x0601E576 RID: 124278
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_CopyEntry_46(HandleRef pThis, HandleRef from, HandleRef key, int deep);

		/// <summary>
		/// Copy the key/value pair associated with the given key in the
		/// given information object.  If deep=1, a deep copy of the information
		/// structure is performed (new instances of any contained vtkInformation and
		/// vtkInformationVector objects are created).
		/// </summary>
		// Token: 0x0601E577 RID: 124279 RVA: 0x002AF0E8 File Offset: 0x002AD2E8
		public void CopyEntry(vtkInformation from, vtkInformationStringVectorKey key, int deep)
		{
			vtkInformation.vtkInformation_CopyEntry_46(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), deep);
		}

		// Token: 0x0601E578 RID: 124280
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_CopyEntry_47(HandleRef pThis, HandleRef from, HandleRef key, int deep);

		/// <summary>
		/// Copy the key/value pair associated with the given key in the
		/// given information object.  If deep=1, a deep copy of the information
		/// structure is performed (new instances of any contained vtkInformation and
		/// vtkInformationVector objects are created).
		/// </summary>
		// Token: 0x0601E579 RID: 124281 RVA: 0x002AF130 File Offset: 0x002AD330
		public void CopyEntry(vtkInformation from, vtkInformationUnsignedLongKey key, int deep)
		{
			vtkInformation.vtkInformation_CopyEntry_47(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), deep);
		}

		// Token: 0x0601E57A RID: 124282
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformation_Get_48(HandleRef pThis, HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set an variant-vector-valued entry.
		/// </summary>
		// Token: 0x0601E57B RID: 124283 RVA: 0x002AF178 File Offset: 0x002AD378
		public vtkVariant Get(vtkInformationVariantVectorKey key)
		{
			vtkVariant result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformation.vtkInformation_Get_48(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, false, out flag);
			}
			return result;
		}

		// Token: 0x0601E57C RID: 124284
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformation_Get_49(HandleRef pThis, HandleRef key, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set an variant-vector-valued entry.
		/// </summary>
		// Token: 0x0601E57D RID: 124285 RVA: 0x002AF1E8 File Offset: 0x002AD3E8
		public vtkVariant Get(vtkInformationVariantVectorKey key, int idx)
		{
			vtkVariant result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformation.vtkInformation_Get_49(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E57E RID: 124286
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Get_50(HandleRef pThis, HandleRef key, HandleRef value);

		/// <summary>
		/// Get/Set an variant-vector-valued entry.
		/// </summary>
		// Token: 0x0601E57F RID: 124287 RVA: 0x002AF25C File Offset: 0x002AD45C
		public void Get(vtkInformationVariantVectorKey key, vtkVariant value)
		{
			vtkInformation.vtkInformation_Get_50(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E580 RID: 124288
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformation_Get_51(HandleRef pThis, HandleRef key, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set an InformationKey-vector-valued entry.
		/// </summary>
		// Token: 0x0601E581 RID: 124289 RVA: 0x002AF2A0 File Offset: 0x002AD4A0
		public vtkInformationKey Get(vtkInformationKeyVectorKey key, int idx)
		{
			vtkInformationKey vtkInformationKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformation.vtkInformation_Get_51(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKey = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKey.Register(null);
				}
			}
			return vtkInformationKey;
		}

		// Token: 0x0601E582 RID: 124290
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformation_Get_52(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set a string-valued entry.
		/// </summary>
		// Token: 0x0601E583 RID: 124291 RVA: 0x002AF328 File Offset: 0x002AD528
		public string Get(vtkInformationStringKey key)
		{
			string s = Marshal.PtrToStringAnsi(vtkInformation.vtkInformation_Get_52(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601E584 RID: 124292
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformation_Get_53(HandleRef pThis, HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set an entry storing another vtkInformation instance.
		/// </summary>
		// Token: 0x0601E585 RID: 124293 RVA: 0x002AF378 File Offset: 0x002AD578
		public vtkInformation Get(vtkInformationInformationKey key)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformation.vtkInformation_Get_53(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		// Token: 0x0601E586 RID: 124294
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformation_Get_54(HandleRef pThis, HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set an entry storing a vtkInformationVector instance.
		/// </summary>
		// Token: 0x0601E587 RID: 124295 RVA: 0x002AF400 File Offset: 0x002AD600
		public vtkInformationVector Get(vtkInformationInformationVectorKey key)
		{
			vtkInformationVector vtkInformationVector = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformation.vtkInformation_Get_54(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationVector = (vtkInformationVector)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationVector.Register(null);
				}
			}
			return vtkInformationVector;
		}

		// Token: 0x0601E588 RID: 124296
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformation_Get_55(HandleRef pThis, HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set an entry storing a vtkObjectBase instance.
		/// </summary>
		// Token: 0x0601E589 RID: 124297 RVA: 0x002AF488 File Offset: 0x002AD688
		public vtkObjectBase Get(vtkInformationObjectBaseKey key)
		{
			vtkObjectBase vtkObjectBase = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformation.vtkInformation_Get_55(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkObjectBase = (vtkObjectBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkObjectBase.Register(null);
				}
			}
			return vtkObjectBase;
		}

		// Token: 0x0601E58A RID: 124298
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformation_Get_56(HandleRef pThis, HandleRef key, int idx, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Manipulate a ObjectBaseVector entry.
		/// </summary>
		// Token: 0x0601E58B RID: 124299 RVA: 0x002AF510 File Offset: 0x002AD710
		public vtkObjectBase Get(vtkInformationObjectBaseVectorKey key, int idx)
		{
			vtkObjectBase vtkObjectBase = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformation.vtkInformation_Get_56(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), idx, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkObjectBase = (vtkObjectBase)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkObjectBase.Register(null);
				}
			}
			return vtkObjectBase;
		}

		// Token: 0x0601E58C RID: 124300
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformation_Get_57(HandleRef pThis, HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set an entry storing a vtkDataObject instance.
		/// </summary>
		// Token: 0x0601E58D RID: 124301 RVA: 0x002AF598 File Offset: 0x002AD798
		public vtkDataObject Get(vtkInformationDataObjectKey key)
		{
			vtkDataObject vtkDataObject = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformation.vtkInformation_Get_57(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkDataObject = (vtkDataObject)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkDataObject.Register(null);
				}
			}
			return vtkDataObject;
		}

		// Token: 0x0601E58E RID: 124302
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformation_Get_58(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an integer-valued entry.
		/// </summary>
		// Token: 0x0601E58F RID: 124303 RVA: 0x002AF620 File Offset: 0x002AD820
		public int Get(vtkInformationIntegerKey key)
		{
			return vtkInformation.vtkInformation_Get_58(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E590 RID: 124304
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformation_Get_59(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set a vtkIdType-valued entry.
		/// </summary>
		// Token: 0x0601E591 RID: 124305 RVA: 0x002AF654 File Offset: 0x002AD854
		public long Get(vtkInformationIdTypeKey key)
		{
			return vtkInformation.vtkInformation_Get_59(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E592 RID: 124306
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkInformation_Get_60(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an double-valued entry.
		/// </summary>
		// Token: 0x0601E593 RID: 124307 RVA: 0x002AF688 File Offset: 0x002AD888
		public double Get(vtkInformationDoubleKey key)
		{
			return vtkInformation.vtkInformation_Get_60(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E594 RID: 124308
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformation_Get_61(HandleRef pThis, HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set an variant-valued entry.
		/// </summary>
		// Token: 0x0601E595 RID: 124309 RVA: 0x002AF6BC File Offset: 0x002AD8BC
		public vtkVariant Get(vtkInformationVariantKey key)
		{
			vtkVariant result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformation.vtkInformation_Get_61(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkVariant)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E596 RID: 124310
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformation_Get_62(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an integer-vector-valued entry.
		/// </summary>
		// Token: 0x0601E597 RID: 124311 RVA: 0x002AF72C File Offset: 0x002AD92C
		public IntPtr Get(vtkInformationIntegerVectorKey key)
		{
			return vtkInformation.vtkInformation_Get_62(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E598 RID: 124312
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformation_Get_63(HandleRef pThis, HandleRef key, int idx);

		/// <summary>
		/// Get/Set an integer-vector-valued entry.
		/// </summary>
		// Token: 0x0601E599 RID: 124313 RVA: 0x002AF760 File Offset: 0x002AD960
		public int Get(vtkInformationIntegerVectorKey key, int idx)
		{
			return vtkInformation.vtkInformation_Get_63(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), idx);
		}

		// Token: 0x0601E59A RID: 124314
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Get_64(HandleRef pThis, HandleRef key, IntPtr value);

		/// <summary>
		/// Get/Set an integer-vector-valued entry.
		/// </summary>
		// Token: 0x0601E59B RID: 124315 RVA: 0x002AF798 File Offset: 0x002AD998
		public void Get(vtkInformationIntegerVectorKey key, IntPtr value)
		{
			vtkInformation.vtkInformation_Get_64(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value);
		}

		// Token: 0x0601E59C RID: 124316
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformation_Get_65(HandleRef pThis, HandleRef key, int idx);

		/// <summary>
		/// Get/Set a string-vector-valued entry.
		/// </summary>
		// Token: 0x0601E59D RID: 124317 RVA: 0x002AF7C8 File Offset: 0x002AD9C8
		public string Get(vtkInformationStringVectorKey key, int idx)
		{
			string s = Marshal.PtrToStringAnsi(vtkInformation.vtkInformation_Get_65(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), idx));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0601E59E RID: 124318
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformation_Get_66(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an integer-pointer-valued entry.
		/// </summary>
		// Token: 0x0601E59F RID: 124319 RVA: 0x002AF818 File Offset: 0x002ADA18
		public IntPtr Get(vtkInformationIntegerPointerKey key)
		{
			return vtkInformation.vtkInformation_Get_66(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E5A0 RID: 124320
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Get_67(HandleRef pThis, HandleRef key, IntPtr value);

		/// <summary>
		/// Get/Set an integer-pointer-valued entry.
		/// </summary>
		// Token: 0x0601E5A1 RID: 124321 RVA: 0x002AF84C File Offset: 0x002ADA4C
		public void Get(vtkInformationIntegerPointerKey key, IntPtr value)
		{
			vtkInformation.vtkInformation_Get_67(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value);
		}

		// Token: 0x0601E5A2 RID: 124322
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkInformation_Get_68(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an unsigned-long-valued entry.
		/// </summary>
		// Token: 0x0601E5A3 RID: 124323 RVA: 0x002AF87C File Offset: 0x002ADA7C
		public uint Get(vtkInformationUnsignedLongKey key)
		{
			return vtkInformation.vtkInformation_Get_68(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E5A4 RID: 124324
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformation_Get_69(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an double-vector-valued entry.
		/// </summary>
		// Token: 0x0601E5A5 RID: 124325 RVA: 0x002AF8B0 File Offset: 0x002ADAB0
		public IntPtr Get(vtkInformationDoubleVectorKey key)
		{
			return vtkInformation.vtkInformation_Get_69(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E5A6 RID: 124326
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkInformation_Get_70(HandleRef pThis, HandleRef key, int idx);

		/// <summary>
		/// Get/Set an double-vector-valued entry.
		/// </summary>
		// Token: 0x0601E5A7 RID: 124327 RVA: 0x002AF8E4 File Offset: 0x002ADAE4
		public double Get(vtkInformationDoubleVectorKey key, int idx)
		{
			return vtkInformation.vtkInformation_Get_70(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), idx);
		}

		// Token: 0x0601E5A8 RID: 124328
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Get_71(HandleRef pThis, HandleRef key, IntPtr value);

		/// <summary>
		/// Get/Set an double-vector-valued entry.
		/// </summary>
		// Token: 0x0601E5A9 RID: 124329 RVA: 0x002AF91C File Offset: 0x002ADB1C
		public void Get(vtkInformationDoubleVectorKey key, IntPtr value)
		{
			vtkInformation.vtkInformation_Get_71(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value);
		}

		// Token: 0x0601E5AA RID: 124330
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformation_GetKey_72(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Upcast the given key instance.
		/// </summary>
		// Token: 0x0601E5AB RID: 124331 RVA: 0x002AF94C File Offset: 0x002ADB4C
		public static vtkInformationKey GetKey(vtkInformationDataObjectKey key)
		{
			vtkInformationKey vtkInformationKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformation.vtkInformation_GetKey_72((key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKey = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKey.Register(null);
				}
			}
			return vtkInformationKey;
		}

		// Token: 0x0601E5AC RID: 124332
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformation_GetKey_73(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Upcast the given key instance.
		/// </summary>
		// Token: 0x0601E5AD RID: 124333 RVA: 0x002AF9CC File Offset: 0x002ADBCC
		public static vtkInformationKey GetKey(vtkInformationDoubleKey key)
		{
			vtkInformationKey vtkInformationKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformation.vtkInformation_GetKey_73((key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKey = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKey.Register(null);
				}
			}
			return vtkInformationKey;
		}

		// Token: 0x0601E5AE RID: 124334
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformation_GetKey_74(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Upcast the given key instance.
		/// </summary>
		// Token: 0x0601E5AF RID: 124335 RVA: 0x002AFA4C File Offset: 0x002ADC4C
		public static vtkInformationKey GetKey(vtkInformationDoubleVectorKey key)
		{
			vtkInformationKey vtkInformationKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformation.vtkInformation_GetKey_74((key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKey = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKey.Register(null);
				}
			}
			return vtkInformationKey;
		}

		// Token: 0x0601E5B0 RID: 124336
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformation_GetKey_75(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Upcast the given key instance.
		/// </summary>
		// Token: 0x0601E5B1 RID: 124337 RVA: 0x002AFACC File Offset: 0x002ADCCC
		public static vtkInformationKey GetKey(vtkInformationInformationKey key)
		{
			vtkInformationKey vtkInformationKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformation.vtkInformation_GetKey_75((key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKey = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKey.Register(null);
				}
			}
			return vtkInformationKey;
		}

		// Token: 0x0601E5B2 RID: 124338
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformation_GetKey_76(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Upcast the given key instance.
		/// </summary>
		// Token: 0x0601E5B3 RID: 124339 RVA: 0x002AFB4C File Offset: 0x002ADD4C
		public static vtkInformationKey GetKey(vtkInformationInformationVectorKey key)
		{
			vtkInformationKey vtkInformationKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformation.vtkInformation_GetKey_76((key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKey = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKey.Register(null);
				}
			}
			return vtkInformationKey;
		}

		// Token: 0x0601E5B4 RID: 124340
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformation_GetKey_77(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Upcast the given key instance.
		/// </summary>
		// Token: 0x0601E5B5 RID: 124341 RVA: 0x002AFBCC File Offset: 0x002ADDCC
		public static vtkInformationKey GetKey(vtkInformationIntegerKey key)
		{
			vtkInformationKey vtkInformationKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformation.vtkInformation_GetKey_77((key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKey = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKey.Register(null);
				}
			}
			return vtkInformationKey;
		}

		// Token: 0x0601E5B6 RID: 124342
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformation_GetKey_78(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Upcast the given key instance.
		/// </summary>
		// Token: 0x0601E5B7 RID: 124343 RVA: 0x002AFC4C File Offset: 0x002ADE4C
		public static vtkInformationKey GetKey(vtkInformationIntegerVectorKey key)
		{
			vtkInformationKey vtkInformationKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformation.vtkInformation_GetKey_78((key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKey = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKey.Register(null);
				}
			}
			return vtkInformationKey;
		}

		// Token: 0x0601E5B8 RID: 124344
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformation_GetKey_79(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Upcast the given key instance.
		/// </summary>
		// Token: 0x0601E5B9 RID: 124345 RVA: 0x002AFCCC File Offset: 0x002ADECC
		public static vtkInformationKey GetKey(vtkInformationRequestKey key)
		{
			vtkInformationKey vtkInformationKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformation.vtkInformation_GetKey_79((key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKey = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKey.Register(null);
				}
			}
			return vtkInformationKey;
		}

		// Token: 0x0601E5BA RID: 124346
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformation_GetKey_80(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Upcast the given key instance.
		/// </summary>
		// Token: 0x0601E5BB RID: 124347 RVA: 0x002AFD4C File Offset: 0x002ADF4C
		public static vtkInformationKey GetKey(vtkInformationStringKey key)
		{
			vtkInformationKey vtkInformationKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformation.vtkInformation_GetKey_80((key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKey = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKey.Register(null);
				}
			}
			return vtkInformationKey;
		}

		// Token: 0x0601E5BC RID: 124348
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformation_GetKey_81(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Upcast the given key instance.
		/// </summary>
		// Token: 0x0601E5BD RID: 124349 RVA: 0x002AFDCC File Offset: 0x002ADFCC
		public static vtkInformationKey GetKey(vtkInformationStringVectorKey key)
		{
			vtkInformationKey vtkInformationKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformation.vtkInformation_GetKey_81((key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKey = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKey.Register(null);
				}
			}
			return vtkInformationKey;
		}

		// Token: 0x0601E5BE RID: 124350
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformation_GetKey_82(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Upcast the given key instance.
		/// </summary>
		// Token: 0x0601E5BF RID: 124351 RVA: 0x002AFE4C File Offset: 0x002AE04C
		public static vtkInformationKey GetKey(vtkInformationKey key)
		{
			vtkInformationKey vtkInformationKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformation.vtkInformation_GetKey_82((key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKey = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKey.Register(null);
				}
			}
			return vtkInformationKey;
		}

		// Token: 0x0601E5C0 RID: 124352
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformation_GetKey_83(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Upcast the given key instance.
		/// </summary>
		// Token: 0x0601E5C1 RID: 124353 RVA: 0x002AFECC File Offset: 0x002AE0CC
		public static vtkInformationKey GetKey(vtkInformationUnsignedLongKey key)
		{
			vtkInformationKey vtkInformationKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformation.vtkInformation_GetKey_83((key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKey = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKey.Register(null);
				}
			}
			return vtkInformationKey;
		}

		// Token: 0x0601E5C2 RID: 124354
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformation_GetKey_84(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Upcast the given key instance.
		/// </summary>
		// Token: 0x0601E5C3 RID: 124355 RVA: 0x002AFF4C File Offset: 0x002AE14C
		public static vtkInformationKey GetKey(vtkInformationVariantKey key)
		{
			vtkInformationKey vtkInformationKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformation.vtkInformation_GetKey_84((key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKey = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKey.Register(null);
				}
			}
			return vtkInformationKey;
		}

		// Token: 0x0601E5C4 RID: 124356
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformation_GetKey_85(HandleRef key, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Upcast the given key instance.
		/// </summary>
		// Token: 0x0601E5C5 RID: 124357 RVA: 0x002AFFCC File Offset: 0x002AE1CC
		public static vtkInformationKey GetKey(vtkInformationVariantVectorKey key)
		{
			vtkInformationKey vtkInformationKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformation.vtkInformation_GetKey_85((key == null) ? default(HandleRef) : key.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationKey = (vtkInformationKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationKey.Register(null);
				}
			}
			return vtkInformationKey;
		}

		// Token: 0x0601E5C6 RID: 124358
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformation_GetNumberOfGenerationsFromBase_86(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E5C7 RID: 124359 RVA: 0x002B004C File Offset: 0x002AE24C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInformation.vtkInformation_GetNumberOfGenerationsFromBase_86(base.GetCppThis(), type);
		}

		// Token: 0x0601E5C8 RID: 124360
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInformation_GetNumberOfGenerationsFromBaseType_87([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E5C9 RID: 124361 RVA: 0x002B006C File Offset: 0x002AE26C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInformation.vtkInformation_GetNumberOfGenerationsFromBaseType_87(type);
		}

		// Token: 0x0601E5CA RID: 124362
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformation_GetNumberOfKeys_88(HandleRef pThis);

		/// <summary>
		/// Return the number of keys in this information object (as would be returned
		/// by iterating over the keys).
		/// </summary>
		// Token: 0x0601E5CB RID: 124363 RVA: 0x002B0088 File Offset: 0x002AE288
		public int GetNumberOfKeys()
		{
			return vtkInformation.vtkInformation_GetNumberOfKeys_88(base.GetCppThis());
		}

		// Token: 0x0601E5CC RID: 124364
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformation_GetRequest_89(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the Request ivar
		/// </summary>
		// Token: 0x0601E5CD RID: 124365 RVA: 0x002B00A8 File Offset: 0x002AE2A8
		public vtkInformationRequestKey GetRequest()
		{
			vtkInformationRequestKey vtkInformationRequestKey = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformation.vtkInformation_GetRequest_89(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformationRequestKey = (vtkInformationRequestKey)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformationRequestKey.Register(null);
				}
			}
			return vtkInformationRequestKey;
		}

		// Token: 0x0601E5CE RID: 124366
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformation_Has_90(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an double-vector-valued entry.
		/// </summary>
		// Token: 0x0601E5CF RID: 124367 RVA: 0x002B0118 File Offset: 0x002AE318
		public int Has(vtkInformationDoubleVectorKey key)
		{
			return vtkInformation.vtkInformation_Has_90(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E5D0 RID: 124368
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformation_Has_91(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an variant-vector-valued entry.
		/// </summary>
		// Token: 0x0601E5D1 RID: 124369 RVA: 0x002B014C File Offset: 0x002AE34C
		public int Has(vtkInformationVariantVectorKey key)
		{
			return vtkInformation.vtkInformation_Has_91(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E5D2 RID: 124370
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformation_Has_92(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an InformationKey-vector-valued entry.
		/// </summary>
		// Token: 0x0601E5D3 RID: 124371 RVA: 0x002B0180 File Offset: 0x002AE380
		public int Has(vtkInformationKeyVectorKey key)
		{
			return vtkInformation.vtkInformation_Has_92(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E5D4 RID: 124372
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformation_Has_93(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set a string-valued entry.
		/// </summary>
		// Token: 0x0601E5D5 RID: 124373 RVA: 0x002B01B4 File Offset: 0x002AE3B4
		public int Has(vtkInformationStringKey key)
		{
			return vtkInformation.vtkInformation_Has_93(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E5D6 RID: 124374
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformation_Has_94(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an entry storing another vtkInformation instance.
		/// </summary>
		// Token: 0x0601E5D7 RID: 124375 RVA: 0x002B01E8 File Offset: 0x002AE3E8
		public int Has(vtkInformationInformationKey key)
		{
			return vtkInformation.vtkInformation_Has_94(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E5D8 RID: 124376
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformation_Has_95(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an entry storing a vtkInformationVector instance.
		/// </summary>
		// Token: 0x0601E5D9 RID: 124377 RVA: 0x002B021C File Offset: 0x002AE41C
		public int Has(vtkInformationInformationVectorKey key)
		{
			return vtkInformation.vtkInformation_Has_95(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E5DA RID: 124378
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformation_Has_96(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an entry storing a vtkObjectBase instance.
		/// </summary>
		// Token: 0x0601E5DB RID: 124379 RVA: 0x002B0250 File Offset: 0x002AE450
		public int Has(vtkInformationObjectBaseKey key)
		{
			return vtkInformation.vtkInformation_Has_96(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E5DC RID: 124380
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformation_Has_97(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Manipulate a ObjectBaseVector entry.
		/// </summary>
		// Token: 0x0601E5DD RID: 124381 RVA: 0x002B0284 File Offset: 0x002AE484
		public int Has(vtkInformationObjectBaseVectorKey key)
		{
			return vtkInformation.vtkInformation_Has_97(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E5DE RID: 124382
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformation_Has_98(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an entry storing a vtkDataObject instance.
		/// </summary>
		// Token: 0x0601E5DF RID: 124383 RVA: 0x002B02B8 File Offset: 0x002AE4B8
		public int Has(vtkInformationDataObjectKey key)
		{
			return vtkInformation.vtkInformation_Has_98(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E5E0 RID: 124384
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformation_Has_99(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Check whether the given key appears in this information object.
		/// </summary>
		// Token: 0x0601E5E1 RID: 124385 RVA: 0x002B02EC File Offset: 0x002AE4EC
		public int Has(vtkInformationKey key)
		{
			return vtkInformation.vtkInformation_Has_99(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E5E2 RID: 124386
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformation_Has_100(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set a request-valued entry.
		/// </summary>
		// Token: 0x0601E5E3 RID: 124387 RVA: 0x002B0320 File Offset: 0x002AE520
		public int Has(vtkInformationRequestKey key)
		{
			return vtkInformation.vtkInformation_Has_100(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E5E4 RID: 124388
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformation_Has_101(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an integer-valued entry.
		/// </summary>
		// Token: 0x0601E5E5 RID: 124389 RVA: 0x002B0354 File Offset: 0x002AE554
		public int Has(vtkInformationIntegerKey key)
		{
			return vtkInformation.vtkInformation_Has_101(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E5E6 RID: 124390
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformation_Has_102(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set a vtkIdType-valued entry.
		/// </summary>
		// Token: 0x0601E5E7 RID: 124391 RVA: 0x002B0388 File Offset: 0x002AE588
		public int Has(vtkInformationIdTypeKey key)
		{
			return vtkInformation.vtkInformation_Has_102(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E5E8 RID: 124392
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformation_Has_103(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an double-valued entry.
		/// </summary>
		// Token: 0x0601E5E9 RID: 124393 RVA: 0x002B03BC File Offset: 0x002AE5BC
		public int Has(vtkInformationDoubleKey key)
		{
			return vtkInformation.vtkInformation_Has_103(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E5EA RID: 124394
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformation_Has_104(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an variant-valued entry.
		/// </summary>
		// Token: 0x0601E5EB RID: 124395 RVA: 0x002B03F0 File Offset: 0x002AE5F0
		public int Has(vtkInformationVariantKey key)
		{
			return vtkInformation.vtkInformation_Has_104(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E5EC RID: 124396
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformation_Has_105(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an integer-vector-valued entry.
		/// </summary>
		// Token: 0x0601E5ED RID: 124397 RVA: 0x002B0424 File Offset: 0x002AE624
		public int Has(vtkInformationIntegerVectorKey key)
		{
			return vtkInformation.vtkInformation_Has_105(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E5EE RID: 124398
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformation_Has_106(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set a string-vector-valued entry.
		/// </summary>
		// Token: 0x0601E5EF RID: 124399 RVA: 0x002B0458 File Offset: 0x002AE658
		public int Has(vtkInformationStringVectorKey key)
		{
			return vtkInformation.vtkInformation_Has_106(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E5F0 RID: 124400
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformation_Has_107(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an integer-pointer-valued entry.
		/// </summary>
		// Token: 0x0601E5F1 RID: 124401 RVA: 0x002B048C File Offset: 0x002AE68C
		public int Has(vtkInformationIntegerPointerKey key)
		{
			return vtkInformation.vtkInformation_Has_107(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E5F2 RID: 124402
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformation_Has_108(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an unsigned-long-valued entry.
		/// </summary>
		// Token: 0x0601E5F3 RID: 124403 RVA: 0x002B04C0 File Offset: 0x002AE6C0
		public int Has(vtkInformationUnsignedLongKey key)
		{
			return vtkInformation.vtkInformation_Has_108(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E5F4 RID: 124404
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformation_IsA_109(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E5F5 RID: 124405 RVA: 0x002B04F4 File Offset: 0x002AE6F4
		public override int IsA(string type)
		{
			return vtkInformation.vtkInformation_IsA_109(base.GetCppThis(), type);
		}

		// Token: 0x0601E5F6 RID: 124406
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformation_IsTypeOf_110([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E5F7 RID: 124407 RVA: 0x002B0514 File Offset: 0x002AE714
		public new static int IsTypeOf(string type)
		{
			return vtkInformation.vtkInformation_IsTypeOf_110(type);
		}

		// Token: 0x0601E5F8 RID: 124408
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformation_Length_111(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an double-vector-valued entry.
		/// </summary>
		// Token: 0x0601E5F9 RID: 124409 RVA: 0x002B0530 File Offset: 0x002AE730
		public int Length(vtkInformationDoubleVectorKey key)
		{
			return vtkInformation.vtkInformation_Length_111(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E5FA RID: 124410
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformation_Length_112(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an variant-vector-valued entry.
		/// </summary>
		// Token: 0x0601E5FB RID: 124411 RVA: 0x002B0564 File Offset: 0x002AE764
		public int Length(vtkInformationVariantVectorKey key)
		{
			return vtkInformation.vtkInformation_Length_112(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E5FC RID: 124412
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformation_Length_113(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an InformationKey-vector-valued entry.
		/// </summary>
		// Token: 0x0601E5FD RID: 124413 RVA: 0x002B0598 File Offset: 0x002AE798
		public int Length(vtkInformationKeyVectorKey key)
		{
			return vtkInformation.vtkInformation_Length_113(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E5FE RID: 124414
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformation_Length_114(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Manipulate a ObjectBaseVector entry.
		/// </summary>
		// Token: 0x0601E5FF RID: 124415 RVA: 0x002B05CC File Offset: 0x002AE7CC
		public int Length(vtkInformationObjectBaseVectorKey key)
		{
			return vtkInformation.vtkInformation_Length_114(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E600 RID: 124416
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformation_Length_115(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an integer-vector-valued entry.
		/// </summary>
		// Token: 0x0601E601 RID: 124417 RVA: 0x002B0600 File Offset: 0x002AE800
		public int Length(vtkInformationIntegerVectorKey key)
		{
			return vtkInformation.vtkInformation_Length_115(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E602 RID: 124418
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformation_Length_116(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set a string-vector-valued entry.
		/// </summary>
		// Token: 0x0601E603 RID: 124419 RVA: 0x002B0634 File Offset: 0x002AE834
		public int Length(vtkInformationStringVectorKey key)
		{
			return vtkInformation.vtkInformation_Length_116(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E604 RID: 124420
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInformation_Length_117(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an integer-pointer-valued entry.
		/// </summary>
		// Token: 0x0601E605 RID: 124421 RVA: 0x002B0668 File Offset: 0x002AE868
		public int Length(vtkInformationIntegerPointerKey key)
		{
			return vtkInformation.vtkInformation_Length_117(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E606 RID: 124422
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Modified_118(HandleRef pThis);

		/// <summary>
		/// Modified signature with no arguments that calls Modified
		/// on vtkObject superclass.
		/// </summary>
		// Token: 0x0601E607 RID: 124423 RVA: 0x002B069C File Offset: 0x002AE89C
		public override void Modified()
		{
			vtkInformation.vtkInformation_Modified_118(base.GetCppThis());
		}

		// Token: 0x0601E608 RID: 124424
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Modified_119(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Modified signature that takes an information key as an argument.
		/// Sets the new MTime and invokes a modified event with the
		/// information key as call data.
		/// </summary>
		// Token: 0x0601E609 RID: 124425 RVA: 0x002B06AC File Offset: 0x002AE8AC
		public void Modified(vtkInformationKey key)
		{
			vtkInformation.vtkInformation_Modified_119(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E60A RID: 124426
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformation_NewInstance_121(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E60B RID: 124427 RVA: 0x002B06DC File Offset: 0x002AE8DC
		public new vtkInformation NewInstance()
		{
			vtkInformation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformation.vtkInformation_NewInstance_121(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601E60C RID: 124428
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Remove_122(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an double-vector-valued entry.
		/// </summary>
		// Token: 0x0601E60D RID: 124429 RVA: 0x002B0738 File Offset: 0x002AE938
		public void Remove(vtkInformationDoubleVectorKey key)
		{
			vtkInformation.vtkInformation_Remove_122(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E60E RID: 124430
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Remove_123(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an variant-vector-valued entry.
		/// </summary>
		// Token: 0x0601E60F RID: 124431 RVA: 0x002B0768 File Offset: 0x002AE968
		public void Remove(vtkInformationVariantVectorKey key)
		{
			vtkInformation.vtkInformation_Remove_123(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E610 RID: 124432
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Remove_124(HandleRef pThis, HandleRef key, HandleRef value);

		/// <summary>
		/// Get/Set an InformationKey-vector-valued entry.
		/// </summary>
		// Token: 0x0601E611 RID: 124433 RVA: 0x002B0798 File Offset: 0x002AE998
		public void Remove(vtkInformationKeyVectorKey key, vtkInformationKey value)
		{
			vtkInformation.vtkInformation_Remove_124(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E612 RID: 124434
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Remove_125(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an InformationKey-vector-valued entry.
		/// </summary>
		// Token: 0x0601E613 RID: 124435 RVA: 0x002B07DC File Offset: 0x002AE9DC
		public void Remove(vtkInformationKeyVectorKey key)
		{
			vtkInformation.vtkInformation_Remove_125(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E614 RID: 124436
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Remove_126(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set a string-valued entry.
		/// </summary>
		// Token: 0x0601E615 RID: 124437 RVA: 0x002B080C File Offset: 0x002AEA0C
		public void Remove(vtkInformationStringKey key)
		{
			vtkInformation.vtkInformation_Remove_126(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E616 RID: 124438
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Remove_127(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an entry storing another vtkInformation instance.
		/// </summary>
		// Token: 0x0601E617 RID: 124439 RVA: 0x002B083C File Offset: 0x002AEA3C
		public void Remove(vtkInformationInformationKey key)
		{
			vtkInformation.vtkInformation_Remove_127(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E618 RID: 124440
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Remove_128(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an entry storing a vtkInformationVector instance.
		/// </summary>
		// Token: 0x0601E619 RID: 124441 RVA: 0x002B086C File Offset: 0x002AEA6C
		public void Remove(vtkInformationInformationVectorKey key)
		{
			vtkInformation.vtkInformation_Remove_128(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E61A RID: 124442
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Remove_129(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an entry storing a vtkObjectBase instance.
		/// </summary>
		// Token: 0x0601E61B RID: 124443 RVA: 0x002B089C File Offset: 0x002AEA9C
		public void Remove(vtkInformationObjectBaseKey key)
		{
			vtkInformation.vtkInformation_Remove_129(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E61C RID: 124444
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Remove_130(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Manipulate a ObjectBaseVector entry.
		/// </summary>
		// Token: 0x0601E61D RID: 124445 RVA: 0x002B08CC File Offset: 0x002AEACC
		public void Remove(vtkInformationObjectBaseVectorKey key)
		{
			vtkInformation.vtkInformation_Remove_130(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E61E RID: 124446
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Remove_131(HandleRef pThis, HandleRef key, HandleRef objectToRemove);

		/// <summary>
		/// Manipulate a ObjectBaseVector entry.
		/// </summary>
		// Token: 0x0601E61F RID: 124447 RVA: 0x002B08FC File Offset: 0x002AEAFC
		public void Remove(vtkInformationObjectBaseVectorKey key, vtkObjectBase objectToRemove)
		{
			vtkInformation.vtkInformation_Remove_131(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (objectToRemove == null) ? default(HandleRef) : objectToRemove.GetCppThis());
		}

		// Token: 0x0601E620 RID: 124448
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Remove_132(HandleRef pThis, HandleRef key, int indexToRemove);

		/// <summary>
		/// Manipulate a ObjectBaseVector entry.
		/// </summary>
		// Token: 0x0601E621 RID: 124449 RVA: 0x002B0940 File Offset: 0x002AEB40
		public void Remove(vtkInformationObjectBaseVectorKey key, int indexToRemove)
		{
			vtkInformation.vtkInformation_Remove_132(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), indexToRemove);
		}

		// Token: 0x0601E622 RID: 124450
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Remove_133(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an entry storing a vtkDataObject instance.
		/// </summary>
		// Token: 0x0601E623 RID: 124451 RVA: 0x002B0970 File Offset: 0x002AEB70
		public void Remove(vtkInformationDataObjectKey key)
		{
			vtkInformation.vtkInformation_Remove_133(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E624 RID: 124452
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Remove_134(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Remove the given key and its data from this information object.
		/// </summary>
		// Token: 0x0601E625 RID: 124453 RVA: 0x002B09A0 File Offset: 0x002AEBA0
		public void Remove(vtkInformationKey key)
		{
			vtkInformation.vtkInformation_Remove_134(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E626 RID: 124454
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Remove_135(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set a request-valued entry.
		/// </summary>
		// Token: 0x0601E627 RID: 124455 RVA: 0x002B09D0 File Offset: 0x002AEBD0
		public void Remove(vtkInformationRequestKey key)
		{
			vtkInformation.vtkInformation_Remove_135(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E628 RID: 124456
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Remove_136(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an integer-valued entry.
		/// </summary>
		// Token: 0x0601E629 RID: 124457 RVA: 0x002B0A00 File Offset: 0x002AEC00
		public void Remove(vtkInformationIntegerKey key)
		{
			vtkInformation.vtkInformation_Remove_136(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E62A RID: 124458
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Remove_137(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set a vtkIdType-valued entry.
		/// </summary>
		// Token: 0x0601E62B RID: 124459 RVA: 0x002B0A30 File Offset: 0x002AEC30
		public void Remove(vtkInformationIdTypeKey key)
		{
			vtkInformation.vtkInformation_Remove_137(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E62C RID: 124460
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Remove_138(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an double-valued entry.
		/// </summary>
		// Token: 0x0601E62D RID: 124461 RVA: 0x002B0A60 File Offset: 0x002AEC60
		public void Remove(vtkInformationDoubleKey key)
		{
			vtkInformation.vtkInformation_Remove_138(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E62E RID: 124462
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Remove_139(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an variant-valued entry.
		/// </summary>
		// Token: 0x0601E62F RID: 124463 RVA: 0x002B0A90 File Offset: 0x002AEC90
		public void Remove(vtkInformationVariantKey key)
		{
			vtkInformation.vtkInformation_Remove_139(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E630 RID: 124464
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Remove_140(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an integer-vector-valued entry.
		/// </summary>
		// Token: 0x0601E631 RID: 124465 RVA: 0x002B0AC0 File Offset: 0x002AECC0
		public void Remove(vtkInformationIntegerVectorKey key)
		{
			vtkInformation.vtkInformation_Remove_140(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E632 RID: 124466
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Remove_141(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set a string-vector-valued entry.
		/// </summary>
		// Token: 0x0601E633 RID: 124467 RVA: 0x002B0AF0 File Offset: 0x002AECF0
		public void Remove(vtkInformationStringVectorKey key)
		{
			vtkInformation.vtkInformation_Remove_141(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E634 RID: 124468
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Remove_142(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an integer-pointer-valued entry.
		/// </summary>
		// Token: 0x0601E635 RID: 124469 RVA: 0x002B0B20 File Offset: 0x002AED20
		public void Remove(vtkInformationIntegerPointerKey key)
		{
			vtkInformation.vtkInformation_Remove_142(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E636 RID: 124470
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Remove_143(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set an unsigned-long-valued entry.
		/// </summary>
		// Token: 0x0601E637 RID: 124471 RVA: 0x002B0B50 File Offset: 0x002AED50
		public void Remove(vtkInformationUnsignedLongKey key)
		{
			vtkInformation.vtkInformation_Remove_143(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E638 RID: 124472
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInformation_SafeDownCast_144(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601E639 RID: 124473 RVA: 0x002B0B80 File Offset: 0x002AED80
		public new static vtkInformation SafeDownCast(vtkObjectBase o)
		{
			vtkInformation vtkInformation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInformation.vtkInformation_SafeDownCast_144((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInformation = (vtkInformation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInformation.Register(null);
				}
			}
			return vtkInformation;
		}

		// Token: 0x0601E63A RID: 124474
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Set_145(HandleRef pThis, HandleRef key, HandleRef value, int length);

		/// <summary>
		/// Get/Set an variant-vector-valued entry.
		/// </summary>
		// Token: 0x0601E63B RID: 124475 RVA: 0x002B0C00 File Offset: 0x002AEE00
		public void Set(vtkInformationVariantVectorKey key, vtkVariant value, int length)
		{
			vtkInformation.vtkInformation_Set_145(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis(), length);
		}

		// Token: 0x0601E63C RID: 124476
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Set_146(HandleRef pThis, HandleRef key, HandleRef value1, HandleRef value2, HandleRef value3);

		/// <summary>
		/// Get/Set an variant-vector-valued entry.
		/// </summary>
		// Token: 0x0601E63D RID: 124477 RVA: 0x002B0C48 File Offset: 0x002AEE48
		public void Set(vtkInformationVariantVectorKey key, vtkVariant value1, vtkVariant value2, vtkVariant value3)
		{
			vtkInformation.vtkInformation_Set_146(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value1 == null) ? default(HandleRef) : value1.GetCppThis(), (value2 == null) ? default(HandleRef) : value2.GetCppThis(), (value3 == null) ? default(HandleRef) : value3.GetCppThis());
		}

		// Token: 0x0601E63E RID: 124478
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Set_147(HandleRef pThis, HandleRef key, HandleRef value1, HandleRef value2, HandleRef value3, HandleRef value4, HandleRef value5, HandleRef value6);

		/// <summary>
		/// Get/Set an variant-vector-valued entry.
		/// </summary>
		// Token: 0x0601E63F RID: 124479 RVA: 0x002B0CB8 File Offset: 0x002AEEB8
		public void Set(vtkInformationVariantVectorKey key, vtkVariant value1, vtkVariant value2, vtkVariant value3, vtkVariant value4, vtkVariant value5, vtkVariant value6)
		{
			vtkInformation.vtkInformation_Set_147(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value1 == null) ? default(HandleRef) : value1.GetCppThis(), (value2 == null) ? default(HandleRef) : value2.GetCppThis(), (value3 == null) ? default(HandleRef) : value3.GetCppThis(), (value4 == null) ? default(HandleRef) : value4.GetCppThis(), (value5 == null) ? default(HandleRef) : value5.GetCppThis(), (value6 == null) ? default(HandleRef) : value6.GetCppThis());
		}

		// Token: 0x0601E640 RID: 124480
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Set_148(HandleRef pThis, HandleRef key, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg1);

		/// <summary>
		/// Get/Set a string-valued entry.
		/// </summary>
		// Token: 0x0601E641 RID: 124481 RVA: 0x002B0D70 File Offset: 0x002AEF70
		public void Set(vtkInformationStringKey key, string arg1)
		{
			vtkInformation.vtkInformation_Set_148(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), arg1);
		}

		// Token: 0x0601E642 RID: 124482
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Set_149(HandleRef pThis, HandleRef key, HandleRef arg1);

		/// <summary>
		/// Get/Set an entry storing another vtkInformation instance.
		/// </summary>
		// Token: 0x0601E643 RID: 124483 RVA: 0x002B0DA0 File Offset: 0x002AEFA0
		public void Set(vtkInformationInformationKey key, vtkInformation arg1)
		{
			vtkInformation.vtkInformation_Set_149(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0601E644 RID: 124484
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Set_150(HandleRef pThis, HandleRef key, HandleRef arg1);

		/// <summary>
		/// Get/Set an entry storing a vtkInformationVector instance.
		/// </summary>
		// Token: 0x0601E645 RID: 124485 RVA: 0x002B0DE4 File Offset: 0x002AEFE4
		public void Set(vtkInformationInformationVectorKey key, vtkInformationVector arg1)
		{
			vtkInformation.vtkInformation_Set_150(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0601E646 RID: 124486
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Set_151(HandleRef pThis, HandleRef key, HandleRef arg1);

		/// <summary>
		/// Get/Set an entry storing a vtkObjectBase instance.
		/// </summary>
		// Token: 0x0601E647 RID: 124487 RVA: 0x002B0E28 File Offset: 0x002AF028
		public void Set(vtkInformationObjectBaseKey key, vtkObjectBase arg1)
		{
			vtkInformation.vtkInformation_Set_151(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0601E648 RID: 124488
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Set_152(HandleRef pThis, HandleRef key, HandleRef value, int idx);

		/// <summary>
		/// Manipulate a ObjectBaseVector entry.
		/// </summary>
		// Token: 0x0601E649 RID: 124489 RVA: 0x002B0E6C File Offset: 0x002AF06C
		public void Set(vtkInformationObjectBaseVectorKey key, vtkObjectBase value, int idx)
		{
			vtkInformation.vtkInformation_Set_152(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis(), idx);
		}

		// Token: 0x0601E64A RID: 124490
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Set_153(HandleRef pThis, HandleRef key, HandleRef arg1);

		/// <summary>
		/// Get/Set an entry storing a vtkDataObject instance.
		/// </summary>
		// Token: 0x0601E64B RID: 124491 RVA: 0x002B0EB4 File Offset: 0x002AF0B4
		public void Set(vtkInformationDataObjectKey key, vtkDataObject arg1)
		{
			vtkInformation.vtkInformation_Set_153(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (arg1 == null) ? default(HandleRef) : arg1.GetCppThis());
		}

		// Token: 0x0601E64C RID: 124492
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Set_154(HandleRef pThis, HandleRef key);

		/// <summary>
		/// Get/Set a request-valued entry.
		/// </summary>
		// Token: 0x0601E64D RID: 124493 RVA: 0x002B0EF8 File Offset: 0x002AF0F8
		public void Set(vtkInformationRequestKey key)
		{
			vtkInformation.vtkInformation_Set_154(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis());
		}

		// Token: 0x0601E64E RID: 124494
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Set_155(HandleRef pThis, HandleRef key, int value);

		/// <summary>
		/// Get/Set an integer-valued entry.
		/// </summary>
		// Token: 0x0601E64F RID: 124495 RVA: 0x002B0F28 File Offset: 0x002AF128
		public void Set(vtkInformationIntegerKey key, int value)
		{
			vtkInformation.vtkInformation_Set_155(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value);
		}

		// Token: 0x0601E650 RID: 124496
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Set_156(HandleRef pThis, HandleRef key, long value);

		/// <summary>
		/// Get/Set a vtkIdType-valued entry.
		/// </summary>
		// Token: 0x0601E651 RID: 124497 RVA: 0x002B0F58 File Offset: 0x002AF158
		public void Set(vtkInformationIdTypeKey key, long value)
		{
			vtkInformation.vtkInformation_Set_156(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value);
		}

		// Token: 0x0601E652 RID: 124498
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Set_157(HandleRef pThis, HandleRef key, double value);

		/// <summary>
		/// Get/Set an double-valued entry.
		/// </summary>
		// Token: 0x0601E653 RID: 124499 RVA: 0x002B0F88 File Offset: 0x002AF188
		public void Set(vtkInformationDoubleKey key, double value)
		{
			vtkInformation.vtkInformation_Set_157(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value);
		}

		// Token: 0x0601E654 RID: 124500
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Set_158(HandleRef pThis, HandleRef key, HandleRef value);

		/// <summary>
		/// Get/Set an variant-valued entry.
		/// </summary>
		// Token: 0x0601E655 RID: 124501 RVA: 0x002B0FB8 File Offset: 0x002AF1B8
		public void Set(vtkInformationVariantKey key, vtkVariant value)
		{
			vtkInformation.vtkInformation_Set_158(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), (value == null) ? default(HandleRef) : value.GetCppThis());
		}

		// Token: 0x0601E656 RID: 124502
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Set_159(HandleRef pThis, HandleRef key, IntPtr value, int length);

		/// <summary>
		/// Get/Set an integer-vector-valued entry.
		/// </summary>
		// Token: 0x0601E657 RID: 124503 RVA: 0x002B0FFC File Offset: 0x002AF1FC
		public void Set(vtkInformationIntegerVectorKey key, IntPtr value, int length)
		{
			vtkInformation.vtkInformation_Set_159(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value, length);
		}

		// Token: 0x0601E658 RID: 124504
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Set_160(HandleRef pThis, HandleRef key, int value1, int value2, int value3);

		/// <summary>
		/// Get/Set an integer-vector-valued entry.
		/// </summary>
		// Token: 0x0601E659 RID: 124505 RVA: 0x002B1030 File Offset: 0x002AF230
		public void Set(vtkInformationIntegerVectorKey key, int value1, int value2, int value3)
		{
			vtkInformation.vtkInformation_Set_160(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value1, value2, value3);
		}

		// Token: 0x0601E65A RID: 124506
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Set_161(HandleRef pThis, HandleRef key, int value1, int value2, int value3, int value4, int value5, int value6);

		/// <summary>
		/// Get/Set an integer-vector-valued entry.
		/// </summary>
		// Token: 0x0601E65B RID: 124507 RVA: 0x002B1064 File Offset: 0x002AF264
		public void Set(vtkInformationIntegerVectorKey key, int value1, int value2, int value3, int value4, int value5, int value6)
		{
			vtkInformation.vtkInformation_Set_161(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value1, value2, value3, value4, value5, value6);
		}

		// Token: 0x0601E65C RID: 124508
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Set_162(HandleRef pThis, HandleRef key, [MarshalAs(UnmanagedType.LPUTF8Str)] string value, int idx);

		/// <summary>
		/// Get/Set a string-vector-valued entry.
		/// </summary>
		// Token: 0x0601E65D RID: 124509 RVA: 0x002B10A0 File Offset: 0x002AF2A0
		public void Set(vtkInformationStringVectorKey key, string value, int idx)
		{
			vtkInformation.vtkInformation_Set_162(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value, idx);
		}

		// Token: 0x0601E65E RID: 124510
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Set_163(HandleRef pThis, HandleRef key, IntPtr value, int length);

		/// <summary>
		/// Get/Set an integer-pointer-valued entry.
		/// </summary>
		// Token: 0x0601E65F RID: 124511 RVA: 0x002B10D4 File Offset: 0x002AF2D4
		public void Set(vtkInformationIntegerPointerKey key, IntPtr value, int length)
		{
			vtkInformation.vtkInformation_Set_163(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value, length);
		}

		// Token: 0x0601E660 RID: 124512
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Set_164(HandleRef pThis, HandleRef key, uint value);

		/// <summary>
		/// Get/Set an unsigned-long-valued entry.
		/// </summary>
		// Token: 0x0601E661 RID: 124513 RVA: 0x002B1108 File Offset: 0x002AF308
		public void Set(vtkInformationUnsignedLongKey key, uint value)
		{
			vtkInformation.vtkInformation_Set_164(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value);
		}

		// Token: 0x0601E662 RID: 124514
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Set_165(HandleRef pThis, HandleRef key, IntPtr value, int length);

		/// <summary>
		/// Get/Set an double-vector-valued entry.
		/// </summary>
		// Token: 0x0601E663 RID: 124515 RVA: 0x002B1138 File Offset: 0x002AF338
		public void Set(vtkInformationDoubleVectorKey key, IntPtr value, int length)
		{
			vtkInformation.vtkInformation_Set_165(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value, length);
		}

		// Token: 0x0601E664 RID: 124516
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Set_166(HandleRef pThis, HandleRef key, double value1, double value2, double value3);

		/// <summary>
		/// Get/Set an double-vector-valued entry.
		/// </summary>
		// Token: 0x0601E665 RID: 124517 RVA: 0x002B116C File Offset: 0x002AF36C
		public void Set(vtkInformationDoubleVectorKey key, double value1, double value2, double value3)
		{
			vtkInformation.vtkInformation_Set_166(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value1, value2, value3);
		}

		// Token: 0x0601E666 RID: 124518
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_Set_167(HandleRef pThis, HandleRef key, double value1, double value2, double value3, double value4, double value5, double value6);

		/// <summary>
		/// Get/Set an double-vector-valued entry.
		/// </summary>
		// Token: 0x0601E667 RID: 124519 RVA: 0x002B11A0 File Offset: 0x002AF3A0
		public void Set(vtkInformationDoubleVectorKey key, double value1, double value2, double value3, double value4, double value5, double value6)
		{
			vtkInformation.vtkInformation_Set_167(base.GetCppThis(), (key == null) ? default(HandleRef) : key.GetCppThis(), value1, value2, value3, value4, value5, value6);
		}

		// Token: 0x0601E668 RID: 124520
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkInformation_SetRequest_168(HandleRef pThis, HandleRef request);

		/// <summary>
		/// Get/Set the Request ivar
		/// </summary>
		// Token: 0x0601E669 RID: 124521 RVA: 0x002B11DC File Offset: 0x002AF3DC
		public void SetRequest(vtkInformationRequestKey request)
		{
			vtkInformation.vtkInformation_SetRequest_168(base.GetCppThis(), (request == null) ? default(HandleRef) : request.GetCppThis());
		}

		// Token: 0x0601E66A RID: 124522
		[DllImport("Kitware.VTK.CommonCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkInformation_UsesGarbageCollector_169(HandleRef pThis);

		/// <summary>
		/// Initiate garbage collection when a reference is removed.
		/// </summary>
		// Token: 0x0601E66B RID: 124523 RVA: 0x002B120C File Offset: 0x002AF40C
		public override bool UsesGarbageCollector()
		{
			return vtkInformation.vtkInformation_UsesGarbageCollector_169(base.GetCppThis()) != 0;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400208F RID: 8335
		public new const string MRFullTypeName = "Kitware.VTK.vtkInformation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04002090 RID: 8336
		public new static readonly string MRClassNameKey = "class vtkInformation";
	}
}
